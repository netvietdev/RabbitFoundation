using System.Collections.Specialized;

namespace Rabbit.Web.MvcNotification.Models
{
    internal class DefaultUserMessageService : IUserMessageService
    {
        public UserMessageViewModel BuildUserMessage(int msgType, NameValueCollection queryString)
        {
            return new UserMessageViewModel()
            {
                Title = "UserMessage",
                Message = "Message is not defined yet"
            };
        }
    }
}