using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Apps.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
          //  var model = PetManagement.GetByName[name];

            //if (model == null)
            //{
            //    return RedirectToAction("NotFound");

            //}
            //return View(model);

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public FileResult DownloadPetPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = "Content/Uploads/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg"; //removing this will load the picture in browser
            return File(picture, contentType, fileName);
        }

        public HttpStatusCodeResult UnauthorizedError()
        {
            return new HttpUnauthorizedResult("Custom Unauthorized Error");
        }

    }
}
