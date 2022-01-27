using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace APBD5.Controllers
{
    [Route("api/warehouses2")]
    [ApiController]
    public class Warehouses2Controller : ControllerBase
    {
        string conString = "Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s20511;Integrated Security=True";

        [HttpPost]
        public async Task<IActionResult> PostAsync(ElementToPost element)
        {

            using (SqlConnection connection = new SqlConnection(conString))
            {

                await connection.OpenAsync();

                SqlTransaction transaction = (SqlTransaction)await connection.BeginTransactionAsync();

                try
                {
                    if (element.Amount is < 0)
                    {
                        await new SqlCommand("RAISERROR('Amount musi byc wieksze od 0');", connection, transaction).ExecuteNonQueryAsync();
                    }
                    else
                    {
                        var com = new SqlCommand("AddProductToWarehouse", connection, transaction);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Amount", element.Amount);
                        com.Parameters.AddWithValue("@IdProduct", element.IdProduct);
                        com.Parameters.AddWithValue("@IdWarehouse", element.IdWarehouse);
                        com.Parameters.AddWithValue("@CreatedAt", element.CreatedAt);

                        await com.ExecuteNonQueryAsync();
                    }

                }
                catch (SqlException sqlError)
                {
                    await transaction.RollbackAsync();
                    return NotFound(sqlError.Message);
                }

                var idX = "";
                var command = new SqlCommand("Select IDENT_CURRENT('Product_Warehouse') as Idx;", connection, transaction);
                using (var sqlDataReader = await command.ExecuteReaderAsync())
                {
                    while (await sqlDataReader.ReadAsync())
                    {
                        idX = sqlDataReader["Idx"].ToString();
                    }
                }
                await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();

                return Ok(idX);

            }

        }
    }
}
