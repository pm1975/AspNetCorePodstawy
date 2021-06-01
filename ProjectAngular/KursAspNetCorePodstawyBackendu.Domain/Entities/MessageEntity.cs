using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursAspNetCorePodstawyBackendu.Domain
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string FirstNameAuthor { get; set; }
        public string LastNameAuthor { get; set; }
    }
}
