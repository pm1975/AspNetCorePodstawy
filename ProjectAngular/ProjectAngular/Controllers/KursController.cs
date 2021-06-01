using KursAspNetCorePodstawyBackendu.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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

        [Authorize("Administrator")]
        [Route("getSomeSecretData")]
        public IActionResult GetSomeSecretData()
        {
            return Ok("SomeSecretKey");
        }

        //This is endpoint
        [HttpGet]
        [Route("getMessage")]
        public IActionResult GetMessage()
        {
            var refreshTime = _configuration.GetValue<int>("Application:RefreshTime");

            var messageDto = new MessageDto
            {
                Content = $"My refresh time is: {refreshTime}",
                Author = "Piotr Mierniczak"
            };
           
            return Ok(messageDto);
        }

        [HttpPost]
        [Route("sendMessage")]
        public IActionResult SendMessage([FromBody]MessageDto messageDto)
        {
            var messageEntitiy = new MessageEntity
            {
                Content = messageDto.Content
            };

            var result = _messagesRepository.Add(messageEntitiy);
            if (result)
            {
                return Ok(messageDto);
            }

            return NotFound();
        }
    }
}
