using System.Collections.Generic;
using System.Collections.Specialized;

namespace Rabbit.Web.MvcNotification.Models
{
    public static class UserMessageServiceContext
    {
        internal static IList<IUserMessageService> UserMessageServices = new List<IUserMessageService>();

        /// <summary>
        /// Get an user message from all configured services. If all returns null, will take the default message.
        /// </summary>
        public static UserMessageViewModel GetUserMessage(int msgType, NameValueCollection queryString)
        {
            foreach (var messageService in UserMessageServices)
            {
                var vm = messageService.BuildUserMessage(msgType, queryString);
                if (vm != null)
                {
                    return vm;
                }
            }

            return new DefaultUserMessageService().BuildUserMessage(msgType, queryString);
        }
    }
}