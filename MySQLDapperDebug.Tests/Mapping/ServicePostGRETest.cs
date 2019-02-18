using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySQLDapperDebug.Mapping;
using MySQLDapperDebug.Models;

namespace MySQLDapperDebug.Tests.Mapping
{
    [TestClass]
    public class ServicePostGRETest
    {

        [TestMethod]
        public void GetRange()
        {
            //build variables
            DateTime old = new DateTime(2018, 1, 1);
            
            //arrange
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetDataByDateTime(old, System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetAverages()
            {
            //build variables
            DateTime old = new DateTime(2018, 1, 1);
            
            //arrange
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetAveragesByDateTime(old,System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
           }
    }
}
