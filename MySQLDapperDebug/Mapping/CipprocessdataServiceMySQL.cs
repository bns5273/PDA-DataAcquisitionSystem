using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServiceMySQL : cipprocessdataDAOFactory
    {
        //connection string hardcoded to test mysql server
        private readonly string connectionString = "server=127.0.0.1;user=root;database=demo;port=3306;password=root";

        public CipprocessdataServiceMySQL()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //test connection string
                conn.Open();
                conn.Close();
            }
            //output exception if any
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //select all records from the database
        public override IEnumerable<cipprocessdata> GetAll()
        {
            //create data object to return
            IEnumerable<cipprocessdata> data;
            //create connection using private string
            using (var connection = new MySqlConnection(this.connectionString))
            {
                //format for Dapper call: stored procedure name, type to create, command type (always should look like this)
                data = connection.Query<cipprocessdata>("selectallcipprocessdata",
                    new cipprocessdata(),
                    commandType: System.Data.CommandType.StoredProcedure);
                //always close the connection
                connection.Close();
            }
            //return data
            return data;
        }

        //select all points from one field
        public override IEnumerable<cipprocessdata> GetField(string field)
        {
            return null;
        }
    }
}
