using APBD7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD7.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private S20511Context context = new S20511Context();

        [HttpDelete("{idClient}")]
        public IActionResult DeleteClient(int idClient)
        {
            
            if (context.Clients.Where(c => c.IdClient == idClient).Any())
            {
                var clientsWithTrips = context.ClientTrips.Where(c => c.IdClient == idClient).ToList();
                if (clientsWithTrips.Count() > 0)
                {
                    return BadRequest("This client has some trips, therefore you can't delete them");
                }

                Client client = context.Clients.Where(c => c.IdClient == idClient).First();

                var ifClient = context.Clients.Where(c => c.IdClient == idClient).Any();
                context.Clients.Remove(client);
                context.SaveChanges();

                return Ok("client with id " + client.IdClient + " deleted");
            }
            else
            {
                return BadRequest("There is no such client");
            }
        }
    }
}
