namespace Rabbit.Web.MvcNotification.Models
{
    public interface IUserMessageService
    {
        UserMessageViewModel BuildUserMessage(int msgType);
    }
}