using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml;

namespace HTML5Demo.Controllers
{
    public class CollectTimeController : Controller
    {
        //
        // GET: /CollectTime/

        public ActionResult Index()
        {
            string dir = @"C:\Users\UglyMelon007\Desktop\腐蚀配置";
            string[] sts = Directory.GetFiles(dir);
            XmlDocument xml = new XmlDocument();
            foreach (string st in sts)
            {
                bool isSave = false;
                xml.Load(st);
                XmlNodeList nodes = xml.SelectNodes("//*[text()='[采集时间]']");
                foreach (XmlNode node in nodes)
                {
                    XmlNodeList nodelist = node.ParentNode.ChildNodes;
                    foreach (XmlNode nd in node.ParentNode.ChildNodes)
                    {
                        if (nd.Name == "Point")
                        {
                            if (nd.InnerText != "AAA-AAA-A-AAAAAA")
                            {
                                nd.InnerText = "AAA-AAA-A-AAAAAA";
                                isSave = true;
                            }
                        }
                        if (nd.Name == "Type")
                        {
                            if (nd.InnerText != "time")
                            {
                                nd.InnerText = "time";
                                isSave = true;
                            }
                        }
                    }
                }
                if(isSave) xml.Save(st);
            }
            return View();
        }

    }
}
