using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySQLDapperDebug.Mapping;

namespace MySQLDapperDebug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //create an instance of the mapping layer
            CipprocessdataServiceMySQL testMySQL = new CipprocessdataServiceMySQL();
            //call the GetAll stored procedure
            var listData = testMySQL.GetAll();
            //take a sample record
            ViewBag.Data = listData.First().Pt1Pressure;
            //send to view
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}