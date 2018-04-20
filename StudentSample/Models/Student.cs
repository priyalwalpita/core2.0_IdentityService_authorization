using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSample.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "Student Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Age")]
        [Range(5,18)]
        public int Age { get; set; }

    }
}
