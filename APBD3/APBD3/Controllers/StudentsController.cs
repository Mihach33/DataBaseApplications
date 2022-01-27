using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text.RegularExpressions;

namespace APBD3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        List<Student> students = new List<Student>();
        public StudentsController()
        {
            using (StreamReader sr = new StreamReader(@".\Data\dane.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    string st = sr.ReadLine();
                    string[] studentInfo = st.Split(",");

                    bool notFull = false;
                    for (var i = 0; i < studentInfo.Length; i++)
                    {
                        if (!(studentInfo[i] != ""))
                        {
                            notFull = true;
                            break;
                        }

                    }

                    if (notFull)
                    {
                        continue;
                    }

                    Student student = new Student
                    {
                        firstName = studentInfo[0],
                        lastName = studentInfo[1],
                        idStudent = "s" + studentInfo[4],
                        birthDay = studentInfo[5],
                        faculty = studentInfo[2],
                        mode = studentInfo[3],
                        mail = studentInfo[6],
                        motherName = studentInfo[7],
                        fatherName = studentInfo[8]
                    };

                    bool ifDublicate = false;
                    for (var i = 0; i < students.Count; i++)
                    {
                        if (student.idStudent == students[i].idStudent)
                        {
                            ifDublicate = true;
                        }
                    }

                    if (ifDublicate)
                    {
                        continue;
                    }

                    students.Add(student);
                }
            }
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpGet("{idStudent}")]
        public IActionResult GetStudent(string idStudent)
        {
            Student st = new Student();
            foreach(var student in students)
            {
                if(student.idStudent == idStudent)
                {
                    st = student;
                    break;
                }
            }
            return Ok(st);
        }

        [HttpDelete("{idStudent}")]
        public IActionResult DeleteStudent(string idStudent)
        {
            foreach (var student in students)
            {
                if (student.idStudent == idStudent)
                {
                    return Ok(students.Remove(student));
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            Regex regex = new Regex("s[0-9]+");
            for(var i = 0; i < students.Count; i++)
            {
                if (regex.IsMatch(student.idStudent))
                {
                    Console.WriteLine("Student with this id already exists");
                    return NotFound("Student with this id already exists");
                }
            }

            if (student.firstName == "" || student.lastName == "" || student.idStudent == "" || student.birthDay == "" || student.faculty == "" || student.mode == "" || student.mail == "" || student.fatherName == "" || student.motherName == "")
            {
                Console.WriteLine("not enough info");
                return NotFound("Not enough info"); 
            }

            students.Add(student);

            foreach (var st in students)
            {
                if (st == student)
                {
                    return Ok(st);
                }
            }
            return NotFound();
        }

        [HttpPut("{idStudent}")]
        public IActionResult UpdateStudent(Student student)
        {
            if (student.firstName == "" || student.lastName == "" || student.idStudent == "" || student.birthDay == "" || student.faculty == "" || student.mode == "" || student.mail == "" || student.fatherName == "" || student.motherName == "")
            {
                Console.WriteLine("not enough info");
                return NotFound("Not enough info");
            }

            foreach (var st in students)
            {
                if (st.idStudent == student.idStudent)
                {
                    st.firstName = student.firstName;
                    st.lastName = student.lastName;
                    st.birthDay = student.birthDay;
                    st.faculty = student.faculty;
                    st.mail = student.mail;
                    st.mode = student.mode;
                    st.motherName = student.motherName;
                    st.fatherName = student.fatherName;
                    return Ok(st);
                }
            }
            return NotFound();
        }

    }
}
