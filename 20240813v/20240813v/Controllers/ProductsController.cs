using _20240813v.DATA.Models;
using _20240813v.DATA.Repository.Interfaces;
using _20240813v.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _20240813v.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //// GET: api/<ProductsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _productRepository.GetAllProductsAsync().Result;
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var data = _productRepository.GetProductByIdAsync(id).Result;

            if (data is null)
            {
                return BadRequest("No existe el producto");
            }

            var response = _productRepository.DeleteProductAsync(id).Result;
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var response = _productRepository.GetProductByIdAsync(id).Result;
            return Ok(response);
        }

        //// POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductDto request)
        {
            var newProduct = new Product
            {
                Nombre = request.Name,
                Descripcion = request.Description,
                Precio = request.Price,
                CantidadEnStock = request.Stock,
                Categoria = request.Category,

            };
            _productRepository.CreateProductAsync(newProduct).Wait();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] UpdateProductDto request)
        {
            var data = _productRepository.GetProductByIdAsync(id).Result;

            if (data is null)
            {
                return BadRequest("No existe el producto");
            }
            data.Nombre = request.Nombre;
            data.Descripcion = request.Descripcion;
            data.Precio = request.Precio;
            data.CantidadEnStock = request.CantidadEnStock;
            data.Categoria = request.Categoria;




            var response = _productRepository.UpdateProductAsync(id, data).Result;

            return Ok();
        }

        //// PUT api/<ProductsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

       

    }
}
