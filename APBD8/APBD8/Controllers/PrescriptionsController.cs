using APBD8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD8.Controllers
{
    
    [Route("api/prescriptions")]
    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        private MainDbContext context = new MainDbContext();
        
        [Authorize]
        [HttpGet("{IdPrescription}")]
        public IActionResult GetPrescription(int IdPrescription)
        {
            var result = context.Prescriptions.Where(p => p.IdPrescription == IdPrescription).Select(p => new
            {
                Date = p.Date,
                DueDate = p.DueDate,
                Doctor = new { p.Doctor.FirstName, p.Doctor.LastName, p.Doctor.Email },
                Patient = new { p.Patient.FirstName, p.Patient.LastName, p.Patient.Birthdate },
                Medicaments = context.Prescription_Medicaments.Where(c => c.IdPrescription == IdPrescription).Select(c => new { c.Medicament.Name, c.Medicament.Description, c.Medicament.Type }).ToList()
            });
            
            return Ok(result);
        }
    }
}
