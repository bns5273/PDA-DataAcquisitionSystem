using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySQLDapperDebug.Mapping;
using MySQLDapperDebug.Models;

namespace MySQLDapperDebug.Tests.Mapping
{
    [TestClass]
    public class ServiceFirebirdTest
    {
        [TestMethod]
        public void GetRange()
        {
            //arrange
            CipprocessdataServiceFirebird testService = new CipprocessdataServiceFirebird();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();
            DateTime old = new DateTime(2018, 1, 1);

            //act
            target = testService.GetDataByDateTime(old, System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetAverages()
        {
            //arrange
            CipprocessdataServiceFirebird testService = new CipprocessdataServiceFirebird();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();
            DateTime old = new DateTime(2018, 1, 1);
            //act
            target = testService.GetAveragesByDateTime(old, System.DateTime.UtcNow);

            //Assert
            Assert.IsNotNull(target);
        }
    }
}
