using _20240813v.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _20240813v.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        //// GET: api/<CalculationsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<CalculationsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CalculationsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CalculationsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CalculationsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        [HttpPost("add")]
        public IActionResult Add([FromBody]CalculationDTO request)
        {
            double result = request.Num1+ request.Num2;
            return Ok(result);
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalculationDTO request)
        {
            double result = request.Num1 - request.Num2;
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] CalculationDTO request)
        {
            double result = request.Num1 * request.Num2;
            return Ok(result);
        }

        [HttpPost("divide")]
        public IActionResult Divide([FromBody] CalculationDTO request)
        {
            if (request.Num2 == 0)
            {
                return BadRequest("No se puede dividir en 0");
            }

            double result = request.Num1 / request.Num2;
            return Ok(result);
        }
    }
}
