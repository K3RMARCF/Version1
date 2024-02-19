using System;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracTest.Server.Data;
using PracTest.Shared.Domain;
using PracTest.Server.IRepository;

namespace PracTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            var tasks = await _unitOfWork.tasks.GetAll();
            return Ok(tasks);
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            var task = await _unitOfWork.tasks.Get(q => q.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            _unitOfWork.tasks.Update(task);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour task)
        {
            await _unitOfWork.tasks.Insert(task);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetTask", new { id = task.Id }, task);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            var task = await _unitOfWork.tasks.Get(q => q.Id == id);

            if (task == null)
            {
                return NotFound();
            }
            await _unitOfWork.tasks.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

            private async Task<bool> ColourExists(int id)
        {
            var Vehicle = await _unitOfWork.tasks.Get(q => q.Id == id);
            return Vehicle != null;
        }
    }

  
}
