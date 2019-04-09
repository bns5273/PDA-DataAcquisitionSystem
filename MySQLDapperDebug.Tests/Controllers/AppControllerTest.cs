using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySQLDapperDebug;
using MySQLDapperDebug.Controllers;

namespace MySQLDapperDebug.Tests.Controllers
{
    [TestClass]
    public class AppControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AppController controller = new AppController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReadData()
        {
            //create instance of database object based on string, pull data from begin to end
            AppController controller = new AppController();
            //give data to view for use with graph - currently placeholders

            // def wrong
            ViewResult result = controller.ReadData("mysql", DateTime.Now, DateTime.Now, "Data" ) as ViewResult;

            //Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void ReadAverages()
        {
            //create instance of database object based on string, pull data from begin to end
            AppController controller = new AppController();
            //give data to view for use with graph - currently placeholders
            ViewResult result = controller.ReadData("mysql", DateTime.Now, DateTime.Now, "Averages") as ViewResult;

            //Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void ReadMovingAverages()
        {
            //create instance of database object based on string, pull data from begin to end
            AppController controller = new AppController();
            //give data to view for use with graph - currently placeholders
            ViewResult result = controller.ReadData("mysql", DateTime.Now, DateTime.Now, "Moving Averages") as ViewResult;

            //Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
