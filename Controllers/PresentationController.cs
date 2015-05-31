using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pres.Web.Models;

namespace Pres.Web.Controllers
{
    public class PresentationController : Controller
    {
        public ActionResult Index()
        {
			var _presentationRepository = new PresentationRepository ();
			var presentations = _presentationRepository.All().Result;
			return View("Index", presentations);
        }
    }
}
