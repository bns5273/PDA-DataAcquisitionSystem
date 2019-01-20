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
        public abstract IEnumerable<cipprocessdata> GetAll();

        //select all points from one field
        public abstract IEnumerable<cipprocessdata> GetField(string field);
        
    }
}