using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Template;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private IFizzBuzzService _FizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _FizzBuzzService = fizzBuzzService;
        }

        [Route("{number:int}")]
        public IActionResult Get(int number)
        {
            if (number < 1 || number > 100) 
                return BadRequest($"Input number \"{number}\" is out of range ");

            return Ok(_FizzBuzzService.Process(number));
        }
    }
}
