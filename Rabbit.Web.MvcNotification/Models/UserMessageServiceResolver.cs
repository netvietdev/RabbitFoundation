namespace Rabbit.Web.MvcNotification.Models
{
    public static class UserMessageServiceResolver
    {
        public static void SetUserMessageService(IUserMessageService userMessageService)
        {
            UserMessageServiceContext.UserMessageServices.Add(userMessageService);
        }
    }
}