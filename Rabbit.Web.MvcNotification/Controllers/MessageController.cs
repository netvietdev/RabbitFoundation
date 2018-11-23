using Rabbit.Web.MvcNotification.Models;
using System.Web.Mvc;

namespace Rabbit.Web.MvcNotification.Controllers
{
    public class MessageController : Controller
    {
        private readonly IUserMessageService _userMessageService;

        public MessageController()
        {
            _userMessageService = UserMessageServiceResolver.GetUserMessageService() ?? new DefaultUserMessageService();
        }

        public ActionResult Index(int type)
        {
            return View(_userMessageService.BuildUserMessage(type));
        }
    }
}