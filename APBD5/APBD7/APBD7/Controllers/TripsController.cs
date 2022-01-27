using APBD7.DTO;
using APBD7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD7.Controllers
{ 

    [Route("api/trips")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private S20511Context context = new S20511Context();

        [HttpGet]
        public IActionResult GetClients()
        {
            var result = context.Trips.Select(t => new{
                Name = t.Name,
                Description = t.Description,
                DateFrom = t.DateFrom,
                DateTo = t.DateTo,
                MaxPeople = t.MaxPeople,
                Countries = t.CountryTrips.Select(ct => new CountryDTO{Name = ct.IdCountryNavigation.Name}).ToList(),
                Clients = t.ClientTrips.Select(ct => new ClientsDTO {FirstName = ct.IdClientNavigation.FirstName, LastName = ct.IdClientNavigation.LastName }).ToList()
            }).OrderByDescending(t => t.DateFrom).ToList();

            return Ok(result);
        }


        [HttpPost("{idTrip}/clients")]
        public IActionResult AddClient(int idTrip, ClientToAdd clientToAdd)
        {
            if (!context.Clients.Where(c => c.Pesel == clientToAdd.Pesel).Any())
            {
                context.Clients.Add(new Client
                {
                    IdClient = context.Clients.Max(c => c.IdClient) + 1,
                    FirstName = clientToAdd.FirstName,
                    LastName = clientToAdd.LastName,
                    Email = clientToAdd.Email,
                    Telephone = clientToAdd.Telephone,
                    Pesel = clientToAdd.Pesel
                });
            }
            else
            {
                var checkId = context.Clients.Where(c => c.Pesel == clientToAdd.Pesel).Select(c => c.IdClient).First();

                if (context.ClientTrips.Where(ct => ct.IdClient == checkId && ct.IdTrip == clientToAdd.IdTrip).Any())
                {
                    return BadRequest("This client already has this trip");
                }
            }

            if (!context.Trips.Where(t => t.IdTrip == idTrip).Any())
            {
                return BadRequest("there is no such trip");
            }

            context.ClientTrips.Add(new ClientTrip
            {
                IdClient = context.Clients.Where(c => c.Pesel == clientToAdd.Pesel).Select(c => c.IdClient).First(),
                IdTrip = clientToAdd.IdTrip,
                PaymentDate = clientToAdd.PaymentDate,
                RegisteredAt = DateTime.Now
            });

            context.SaveChanges();

            return Ok();
        }
    }
}
