using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySQLDapperDebug.Mapping;
using MySQLDapperDebug.Models;
using Newtonsoft.Json;

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
            cipprocessdataDAO conn = cipprocessdataDAOfactory.getDAO(dataBase);
            List<cipprocessdata> data = new List<cipprocessdata>();
            //create instance of database object based on string, pull data from begin to end

            data = conn.GetDataByDateTime(begin, end);
            String model = JsonConvert.SerializeObject(data);
            ViewData["Data"] = data;
            return View(data);
        }

        public ActionResult ReadAverages(string dataBase, DateTime begin, DateTime end)
        {
            //create instance of database object based on string, pull data from begin to end

            //give data to view for use with graph
            return View();
        }
    }
}