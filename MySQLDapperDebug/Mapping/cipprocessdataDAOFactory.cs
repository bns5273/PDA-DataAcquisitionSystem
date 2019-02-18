using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySQLDapperDebug.Models;
using MySql.Data;

namespace MySQLDapperDebug.Mapping
{
    public abstract class cipprocessdataDAOFactory
    {
        //select all records from the database
        public abstract List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end);

        //select all points from one field
        public abstract List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end);
        
    }
}