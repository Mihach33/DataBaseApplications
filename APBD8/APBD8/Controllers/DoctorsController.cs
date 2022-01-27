using APBD8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD8.Controllers
{
    [Authorize]
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private MainDbContext context = new MainDbContext();

        [Authorize]
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(context.Doctors.ToList());
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            if (context.Doctors.Where(d => d.IdDoctor == doctor.IdDoctor).Any())
            {
                return BadRequest("Doctor with this id already exists");
            }

            context.Doctors.Add(doctor);

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Doctors ON;");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Doctors OFF;");
            }
            finally
            {
                context.Database.CloseConnection();
            }
            return Ok("Added " + doctor);
        }

        [Authorize]
        [HttpDelete("{IdDoctor}")]
        public IActionResult DeleteDoctor(int IdDoctor)
        {
            if (context.Prescriptions.Where(p => p.IdDoctor == IdDoctor).Any())
            {
                return BadRequest("Can't delete this doctor, because they have prescriptions");
            }

            if (context.Doctors.Where(d => d.IdDoctor == IdDoctor).Any())
            {
                var doctor = context.Doctors.Where(d => d.IdDoctor == IdDoctor).First();
                context.Doctors.Remove(doctor);
            }
            else
            {
                return BadRequest("There is no doctor with this id");
            }

            context.SaveChanges();

            return Ok("Doctor with id " + IdDoctor + " was removed");
        }

        [Authorize]
        [HttpPut]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            var doctorToUpdate = context.Doctors.Where(d => d.IdDoctor == doctor.IdDoctor).First();
            if (!doctor.FirstName.Equals(""))
            {
                doctorToUpdate.FirstName = doctor.FirstName;
            }
            if (!doctor.LastName.Equals(""))
            {
                doctorToUpdate.LastName = doctor.LastName;
            }
            if (!doctor.Email.Equals(""))
            {
                doctorToUpdate.Email = doctor.Email;
            }

            context.SaveChanges();

            return Ok(doctorToUpdate);
        }
    }
}
