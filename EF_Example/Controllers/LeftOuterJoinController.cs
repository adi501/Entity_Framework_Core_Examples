using EF_Example.Data;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeftOuterJoinController : ControllerBase
    {
        private readonly AppDbContext _db;

        public LeftOuterJoinController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/<LeftOuterJoinController>
        [HttpGet]
        public IEnumerable<object> Get()
        {
            //Performing Left Outer Join using LINQ using Query Syntax
            //Left Data Source: tbl_Courses
            //Right Data Source: tbl_Students
            //Note: Left and Right Data Source Matters
            var data = from course in _db.Courses  //Left Data Source
                       join student in _db.Students  //Right Data Source
                       on course.Id equals student.Course_Id //Inner Join Condition
                       into stude //Performing LINQ Group Join
                       from stu in stude.DefaultIfEmpty() //Performing Left Outer Join
                       select new { stu.Name, course_Name = course.Name }; //Projecting the Result to Anonymous Type
            return data;
        }

    }
}
