using KursAspNetCorePodstawyBackendu.Database;
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
        private readonly IMessagesRepository _messagesRepository;

        public KursController(IConfiguration configuration, IMessagesRepository messagesRepository)
        {
            _configuration = configuration;
            _messagesRepository = messagesRepository;
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
            var messageEntitiy = new MessageEntity
            {
                Content = message.Content
            };

            var result = _messagesRepository.Add(messageEntitiy);
            if (result)
            {
                return Ok(message);
            }

            return NotFound();
        }
    }
}
