using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace APBD4.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        string conString = "Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s20511;Integrated Security=True";

        [HttpGet]
        public IActionResult GetInOrder(string orderBy)
        {
            var animals = new List<Animal>();
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                if (orderBy == null)
                {
                    com.CommandText = "SELECT * FROM Animal ORDER BY name ASC";
                }
                else
                {
                    com.CommandText = "SELECT * FROM Animal ORDER BY " + orderBy + " ASC";
                }


                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    animals.Add(new Animal
                    {

                        Name = dr["Name"].ToString(),
                        IdAnimal = (int)dr["IdAnimal"],
                        Description = dr["Description"].ToString(),
                        Category = dr["Category"].ToString(),
                        Area = dr["Area"].ToString()
                    });
                }

            }
            return Ok(animals);
        }


        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            if (animal.Name == "" || animal.Description == ""
               || animal.Category == "" || animal.Area == "")
            {
                return NotFound("Not enough info");
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "SET IDENTITY_INSERT Animal ON; INSERT INTO Animal(IdAnimal, Name, Description, Category, Area) VALUES ('"
                    + animal.IdAnimal + "','" + animal.Name + "','" + animal.Description + "','"
                    + animal.Category + "','" + animal.Area + "'); SET IDENTITY_INSERT Animal OFF";

                con.Open();
                com.ExecuteNonQuery();
            }
            return Ok();
        }


        [HttpPut("{idAnimal}")]
        public IActionResult UpdateAnimal(Animal animal)
        {
            if (animal.Name == null || animal.Description == null || animal.Category == null || animal.Area == null)
            {
                return NotFound("Not enough info");
            }
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Animal SET Name='" + animal.Name + "',Description='" + animal.Description + "',Category='"
                    + animal.Category + "',Area='" + animal.Area + "' WHERE IdAnimal=" + animal.IdAnimal + ";";

                con.Open();
                com.ExecuteNonQuery();

            }

            return Ok();
        }

        [HttpDelete("{idAnimal}")]
        public IActionResult DeleteAnimal(string id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "DELETE FROM Animal WHERE IdAnimal=" + id + ";";

                con.Open();
                com.ExecuteNonQuery();

            }

            return Ok();
        }

    }
}
