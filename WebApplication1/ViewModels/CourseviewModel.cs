using Microsoft.VisualBasic;

namespace WebApplication1.ViewModels
{
    public class CourseviewModel
    {
        public int CourseId { get; set; }
        public string coursename { get; set; }
        public string CourseDescription { get; set; }
        public DateAndTime CreatedDate { get; set; }
        public decimal RevisonNumber { get; set; }
        public int CreatedBy { get; set; }
        public string Author { get; set; }
    }
}
