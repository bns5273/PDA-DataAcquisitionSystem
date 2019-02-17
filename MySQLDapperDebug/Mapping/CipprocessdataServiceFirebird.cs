using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServiceFirebird : cipprocessdataDAOFactory
    {
        //need connection string for Firebird server here

        public CipprocessdataServiceFirebird()
        {
            //implement
        }

        //select all records from the database
        public override IEnumerable<cipprocessdata> GetAll()
        {
            //create data object to return
            IEnumerable<cipprocessdata> data = null;
            //create connection using private string
            //implement
            //return data
            return data;
        }

        //select all points from one field
        public override IEnumerable<cipprocessdata> GetField(string field)
        {
            //create data object to return
            IEnumerable<cipprocessdata> data;
            //create connection using private string
            //implement
            //return data
            return null;
        }
    }
}
