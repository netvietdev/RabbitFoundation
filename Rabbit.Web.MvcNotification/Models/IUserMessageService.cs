using System.Collections.Specialized;

namespace Rabbit.Web.MvcNotification.Models
{
    public interface IUserMessageService
    {
        /// <summary>
        /// Build a specific user message based on given parameters.
        /// </summary>
        UserMessageViewModel BuildUserMessage(int msgType, NameValueCollection queryString);
    }
}