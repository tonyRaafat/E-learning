using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_learing.Models
{
    public class CourseCategory
    {
        public int Id {get; set;}
        [Required]
        [DisplayName("Category Name")]
        public string? Name {get; set;}
    }
}