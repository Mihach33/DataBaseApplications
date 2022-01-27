using APBD11.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APBD11.Server.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>();
        public Student myStudent = new Student();

        static StudentsController() 
        {
            
            
            _students.Add(new Student
            {
                IdStudent = 1,
                Avatar = "https://image.flaticon.com/icons/png/512/921/921071.png",
                FirstName = "John",
                LastName = "Smith",
                BirthDate = new DateTime(2001,10,20),
                Studies = "Management"
            });
            
            _students.Add(new Student
            {
                IdStudent = 2,
                Avatar = "https://image.flaticon.com/icons/png/512/921/921071.png",
                FirstName = "Pablo",
                LastName = "Bursh",
                BirthDate = new DateTime(2000,09,13),
                Studies = "Informatics"
            });
            
            _students.Add(new Student
            {
                IdStudent = 3,
                Avatar = "https://image.flaticon.com/icons/png/512/921/921071.png",
                FirstName = "Adam",
                LastName = "Sandler",
                BirthDate = new DateTime(1999,04,19),
                Studies = "Management"
            });
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_students);
        }

        [HttpGet]
        [Route("{id}")]
        public Student GetOneStudent(int id)
        {
            return _students.Where(s => s.IdStudent == id).FirstOrDefault();
        }
        
    }
}
