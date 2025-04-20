using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Net_React_Ödev_Nisan___2
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly string _connectionstring;
        public ProductController(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("AdonetConnection");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string query = "Select * from Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2),
                        Stock = reader.GetInt32(3)
                    });
                }
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string query = "SELECT Id, Name, Price, Stock FROM Products WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2),
                        Stock = reader.GetInt32(3)
                    };
                }
            }

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                String query = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                conn.Open();
                cmd.ExecuteReader();
            }
            return Ok("Ürün eklendi.");
        }

        [HttpPut]
        public IActionResult Uptade(int id, Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string query = "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                    return NotFound();
            }
            return Ok("Ürün güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                string query = "DELETE FROM Products WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                    return NotFound();
            }

            return Ok("Ürün silindi.");
        }
    }
}
