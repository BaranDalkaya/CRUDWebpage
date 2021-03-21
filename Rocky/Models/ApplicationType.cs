using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name should be less that 20 characters.")]
        public string Name { get; set; }
    }
}
