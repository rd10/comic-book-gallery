using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                return Redirect("/");
                //return new RedirectResult("/"); above line is the same
            }

            return Content("From the comic books controller");
            /*return new ContentResult()
            {
                Content = "From the comic books controller"
            };*/
            
        }
    }
}