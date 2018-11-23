namespace Rabbit.Web.MvcNotification.Models
{
    public class DefaultUserMessageService : IUserMessageService
    {
        public UserMessageViewModel BuildUserMessage(int msgType)
        {
            return new UserMessageViewModel()
            {
                Title = "Unknown"
            };
        }
    }
}