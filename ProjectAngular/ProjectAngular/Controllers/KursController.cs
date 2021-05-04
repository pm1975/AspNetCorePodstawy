using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAngular.Controllers
{
    [ApiController]
    [Route("kurs")]
    public class KursController : ControllerBase
    {
        public KursController()
        {
        }

        //This is endpoint
        [HttpGet]
        [Route("getMessage")]
        public IActionResult GetMessage()
        {
            var message = new { message = "Hej, jestem backendowcem!" };

            return Ok(message);
        }

    }
}
