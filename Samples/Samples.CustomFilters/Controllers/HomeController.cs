using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samples.CustomFilters.Models.Exceptions;

namespace Samples.CustomFilters.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            throw new EntityNotFoundException();

            return View();
        }

        public ActionResult Browse(int id)
        {
            return new ContentResult()
            {
                Content = id.ToString(CultureInfo.InvariantCulture)
            };
        }

    }
}
