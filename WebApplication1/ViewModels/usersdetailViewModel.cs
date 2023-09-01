using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class usersdetailViewModel
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        [Required]
        public string MobileNumber { get; set; }
    }
}
