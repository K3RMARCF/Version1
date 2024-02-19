using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracTest.Shared.Domain
{
    public class Speed: BaseDomainModel
    {
        public int Id { get; set; }

        
        
        public string? Name { get; set; }
        
        public string? HexCode { get; set;}

        [Required]
        public double SpeedValue { get; set; }

    }
}
