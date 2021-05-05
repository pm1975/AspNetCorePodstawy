using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        private readonly IConfiguration _configuration;

        public KursController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //This is endpoint
        [HttpGet]
        [Route("getMessage")]
        public IActionResult GetMessage()
        {
            var refreshTime = _configuration.GetValue<int>("Application:RefreshTime");

            var message = new Message
            {
                Content = $"My refresh time is: {refreshTime}",
                Author = "Piotr Mierniczak"
            };
           
            return Ok(message);
        }

        [HttpPost]
        [Route("sendMessage")]
        public IActionResult SendMessage([FromBody]Message message)
        {
            return Ok(message);
        }
    }
}
