using prjVidlyDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjVidlyDemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
      var movie = new Movie() { Name = "屍速列車：感染半島" };
            return View(movie);
        }
    }
}