using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorDemo.Data
{
    public class Person
    {
        [Required]
        [Range(18, 65)]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}