using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML5Demo.Controllers
{
    public class JqueryFileUploadController : Controller
    {
        //
        // GET: /JqueryFileUpload/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            Response.ContentType = "text/plain";
            Response.Charset = "utf-8";

            return Content("hello");
        }
    }
}
