using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pres.Web.Models;
using MongoDB.Bson;

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

		public ActionResult View(string id, int? pageNumber)
		{
			var _presentationRepository = new PresentationRepository ();
			var model = _presentationRepository.GetPage (ObjectId.Parse(id), pageNumber).Result;
			ViewBag.Id = id;
			return View("View", model);
		}
    }
}
