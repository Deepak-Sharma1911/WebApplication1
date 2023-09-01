using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class userController : ControllerBase
    {

        private readonly WebAppDbContext _context;
        public readonly userservice _logger;

        public userController(WebAppDbContext context,)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usermodel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/user-management/Createuser")]
        public async Task<IActionResult> userRegistration(usersdetailViewModel usermodel)
        {
            if (!ModelState.IsValid) { return BadRequest(usermodel); }

            User userObject = new User()
            {
                Firstname = usermodel.Firstname,
                LastName = usermodel.LastName,
                Age = usermodel.Age,
                MobileNumber = usermodel.MobileNumber,

            };
            await _context.users.AddAsync(userObject);
            await _context.SaveChangesAsync();
            return Ok(usermodel);
        }


        //userInfomationApi
        //userCourses
        //userscourseprogress
        //userAllCourseprogress


        [HttpPost]
        [Route("/api/Course-management/CreateCourse")]
        public async Task<IActionResult> CourseviewModel(CourseviewModel usermodel)
        {
            if (!ModelState.IsValid) { return BadRequest(usermodel); }

            Course courobject = new Course()
            {
                CourseId = 1,
                coursename = usermodel.coursename,
                CourseDescription = usermodel.CourseDescription,
                CreatedBy = usermodel.CreatedBy,
                CreatedDate = DateTime.UtcNow,
                Author = usermodel.Author,

            };
            await _context.Courses.AddAsync(courobject);
            await _context.SaveChangesAsync();
            return Ok(usermodel);
        }


        [HttpGet]
        [Route("/api/Course-management/GetCoursenameSearch/{coursename}")]
        public async Task<IActionResult> GetCoursenameSearch(string coursename)
        {
            var result = await _context.Courses.Where(x => x.coursename.ToLower().Trim().Equals(coursename.ToLower().Trim())
                                                 || x => x.coursename.ToLower().Trim().Equals(coursename.ToLower().Trim())).AsNoTracking().FirstOrDefaultAsync();
            if (result != null)
            {
                return Ok(result);
            }
            return NoContent();
        }


    }
}
