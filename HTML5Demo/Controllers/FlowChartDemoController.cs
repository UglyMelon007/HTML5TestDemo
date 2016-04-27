using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using RTDB.IP21;

namespace HTML5Demo.Controllers
{
    public class FlowChartDemoController : Controller
    {
        //
        // GET: /FlowChartDemo/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowXmlName()
        {
            string dir = System.AppDomain.CurrentDomain.BaseDirectory + @"Content\FlowChartTestDemo";
            string[] sts = Directory.GetFiles(dir);
            ArrayList fileNames = new ArrayList();
            foreach (string st in sts)
            {
                if(Path.GetExtension(st).Contains("xml")) fileNames.Add(Path.GetFileName(st));
            }
            //PointName();
            return Json(fileNames);
        }

        //public ActionResult PointName()
        //{
        //    List<string> al = new List<string>();
        //    al.Add("TIJ_DCU2_FLT_FE_P");
        //    //Dictionary<string, string> dicValue = RtdbConnectionFactory.GetRtdbConnectionFactory().GetConnection().GetCurrentData(al);
        //    //return Json(dicValue);
        //}
    }
}
