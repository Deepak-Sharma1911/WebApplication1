using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebApplication1.models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string coursename { get; set; }
        public string CourseDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public decimal RevisonNumber { get; set; }
        public int CreatedBy { get; set; }
        public string Author { get; set; }
    }
}
