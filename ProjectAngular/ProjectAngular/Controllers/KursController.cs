using Microsoft.AspNetCore.Mvc;
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
        public KursController()
        {
        }

        //This is endpoint
        [HttpGet]
        [Route("getMessage")]
        public IActionResult GetMessage()
        {
            var message = new Message
            {
                Content = "Hej, jestem backendowcem!",
                Author = "Piotr Mierniczak"
            };

            var serializedMessage = JsonConvert.SerializeObject(message);
            
            var deserializedMessage = JsonConvert.DeserializeObject<Message>(serializedMessage);
            
            return Ok(message);
        }

    }
}
