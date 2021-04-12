using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {
        List<Student> studentsList = new List<Student>();
        public StudentsController()
        {
            for(int i=0;i<4;i++)
                studentsList.Add(new Student());
            studentsList[0].Name = "Ronaldo Hernandez";
            studentsList[1].Name = "Vanesa Soliz";
            studentsList[2].Name = "Sandra Villantino";
            studentsList[3].Name = "Esteban Javerino";
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return studentsList;
        }
        [HttpPost]
        public Student CreateStudent([FromBody] string studentName)
        {
            return new Student()
            {
                Name = studentName
            };
        }
        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            student.Name = "updated";
            return student;
        }
        [HttpDelete]
        public Student DeleteStudent([FromBody] Student student)
        {
            student.Name = "deleted";
            return student;
        }
    }
}
