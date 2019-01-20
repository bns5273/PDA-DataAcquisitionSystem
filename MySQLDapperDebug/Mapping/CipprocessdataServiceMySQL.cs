using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySQLDapperDebug.Models;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServiceMySQL : cipprocessdataDAOFactory
    {

        private readonly string connectionString = "server=127.0.0.1;user=root;database=demo;port=3306;password=root";

        public CipprocessdataServiceMySQL()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //select all records from the database
        public override IEnumerable<cipprocessdata> GetAll()
        {
            return null;
        }

        //select all points from one field
        public override IEnumerable<cipprocessdata> GetField(string field)
        {
            return null;
        }
    }
}
