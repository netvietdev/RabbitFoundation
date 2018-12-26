using Rabbit.Web.MvcNotification.Models;
using System.Web.Mvc;

namespace Rabbit.Web.MvcNotification.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Index(int type)
        {
            var vm = UserMessageServiceContext.GetUserMessage(type, HttpContext.Request.QueryString);
            return View(vm);
        }
    }
}