namespace Rabbit.Web.MvcNotification.Models
{
    public class UserMessageServiceResolver
    {
        private static IUserMessageService _userMessageService;

        public static void SetUserMessageService(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }

        public static IUserMessageService GetUserMessageService()
        {
            return _userMessageService;
        }
    }
}