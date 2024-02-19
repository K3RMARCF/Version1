using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracTest.Shared.Domain
{
    public class Colour: BaseDomainModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string? Name { get; set; }
        [Required]
        public string? HexCode { get; set;}



    }
}
