using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD7.DTO
{
    public class TripDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int MaxPeople { get; set; }

        public virtual List<CountryDTO> CountriesInTrip { get; set; }
        public virtual List<ClientsDTO> ClientsInTrip { get; set; }
    }

    public class CountryDTO
    {
        public string Name { get; set; }
    }

    public class ClientsDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
