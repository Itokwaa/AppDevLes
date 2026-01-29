using API_Demo.Entities;
using API_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //anyareeeee
        [HttpGet]
        [Route("Product/All")]
        public List<Product> GetAllProducts()
        {
            ProductServices services = new ProductServices();
            return services.GetAllProducts();
        }

        //new metehiw
        [HttpPost]
        [Route("Product/Add")]
        //public void AddProduct(Product product) perst method
        public IActionResult AddProduct(Product product) 
        {
            //product.Print();
            ProductServices services = new ProductServices();
            services.AddProduct(product);
            return StatusCode(201);
            //breakpoint yung belog sa geled ng linenumber
            //Console.WriteLine(product.Id);
            //Console.WriteLine(product.Name);
            //Console.WriteLine(product.Price);
           
            //tamad public void Print()
            // {
            //      COnsole.WriteLine($"ID :{product.ID}");
            //      so on 
            //  }

        }

        //deletemet
        [HttpDelete]
        [Route("Delete/Product/{id}")]
        public IActionResult DeleteProduct(int id )
        {
            ProductServices services = new ProductServices();
            services.DeleteProduct(id);

            return StatusCode(200);

        }
    }
}
