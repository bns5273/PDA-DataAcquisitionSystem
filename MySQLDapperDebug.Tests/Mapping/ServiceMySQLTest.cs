using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySQLDapperDebug.Mapping;
using MySQLDapperDebug.Models;

namespace MySQLDapperDebug.Tests.Mapping
{
    [TestClass]
    public class ServiceMySQLTest
    {
        [TestMethod]
        public void GetAll()
        {
            //arrange
            CipprocessdataServiceMySQL testService = new CipprocessdataServiceMySQL();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();


            //act
            target = testService.GetAll();

            //Assert
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetField()
        {
            //arrange
            CipprocessdataServiceMySQL testService = new CipprocessdataServiceMySQL();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetField("\"id\"");

            //Assert
            Assert.IsNotNull(target);
        }
    }
}
