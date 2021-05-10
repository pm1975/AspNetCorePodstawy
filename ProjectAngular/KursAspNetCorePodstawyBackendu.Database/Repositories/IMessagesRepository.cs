using System.Collections.Generic;

namespace KursAspNetCorePodstawyBackendu.Database
{
    public interface IMessagesRepository
    {
        List<MessageEntity> GetAll();
        bool Add(MessageEntity message);
        bool Delete(MessageEntity message);
    }
}