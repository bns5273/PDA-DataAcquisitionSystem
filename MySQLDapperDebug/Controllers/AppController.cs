using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySQLDapperDebug.Mapping;

namespace MySQLDapperDebug.Controllers
{
    public class AppController : Controller
    {
        public ActionResult Index() //default run page; creates the layout but does not populate with data; our "blank constructor"
        {
            return View();
        }

        public ActionResult ReadData(string dataBase, DateTime begin, DateTime end)
        {
            //create instance of database object based on string, pull data from begin to end

            //give data to view for use with graph
            return View();
        }

        public ActionResult ReadAverages(string dataBase, DateTime begin, DateTime end)
        {
            //create instance of database object based on string, pull data from begin to end

            //give data to view for use with graph
            return View();
        }
    }
}