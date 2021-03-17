using System;
using Microsoft.AspNetCore.Mvc;

namespace IterationHelper.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class IterationController : ControllerBase
    {
        public IterationController()
        {

        }

        [HttpGet("getIterationNumber")]
        public IActionResult GetIterationNumber()
        {
            var rand = new Random();
            return Ok(rand.Next(100, 1000));
        }
    }
}