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
        public void GetRange()
        {
            //build variables
            DateTime old = new DateTime(2018, 1, 1);
            
            //arrange
            CipprocessdataServiceMySQL testService = new CipprocessdataServiceMySQL();
            List<cipprocessdata> target = new List<cipprocessdata>();
            //act
            target = testService.GetDataByDateTime(old, System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target[0]);
        }

        [TestMethod]
        public void GetAverages()
            {
            //build variables
            DateTime old = new DateTime(2018, 1, 1);
            
            //arrange
            CipprocessdataServiceMySQL testService = new CipprocessdataServiceMySQL();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetAveragesByDateTime(old,System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
           }

        [TestMethod]
        public void GetMovingAverages()
        {
            //build variables
            DateTime old = new DateTime(2018, 1, 1);

            //arrange
            CipprocessdataServiceMySQL testService = new CipprocessdataServiceMySQL();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetMovingAveragesByDateTime(old, System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
        }
    }
}
