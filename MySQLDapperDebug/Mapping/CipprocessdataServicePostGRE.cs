﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServicePostGRE : cipprocessdataDAO
    {
        //need private connection string for postgre server here

        public CipprocessdataServicePostGRE()
        {
             //implement
        }

        //select all records from the database
        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            //create data object to return
            List<cipprocessdata> data = null;
            //create connection using private string
            //implement
            //return data
            return data;
        }

        //select all points from one field
        public override List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end)
        {
            //create data object to return
            List<cipprocessdata> data = null;
            //create connection using private string
             //implement
            //return data
            return data;
        }
    }
}
