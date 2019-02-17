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
        public void GetAll()
        {
            //arrange
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
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
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetField("\"id\"");

            //Assert
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetRange(DateTime begin, DateTime end)
        {
            //arrange
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetRange(begin, end);

            //Assert
            Assert.IsNotNull(target);
        }

        [TestMethod]
        public void GetAverages(DateTime begin, DateTime end)
        {
            //arrange
            CipprocessdataServicePostGRE testService = new CipprocessdataServicePostGRE();
            IEnumerable<cipprocessdata> target = new List<cipprocessdata>();

            //act
            target = testService.GetAverages(begin, end);

            //Assert
            Assert.IsNotNull(target);
        }
    }
}
