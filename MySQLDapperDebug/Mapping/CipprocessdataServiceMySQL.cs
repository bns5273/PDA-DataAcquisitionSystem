using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServiceMySQL : cipprocessdataDAO
    {
        //connection string hardcoded to test mysql server
        private readonly string connectionString = "server=10.0.1.237;user=root;database=testdb;port=3306;password=C0ll3ct10n";

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
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //get all data by DateTime
        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            //create data object for return
            IEnumerable<cipprocessdata> data;
            //move variables into the Dapper object
            var p = new DynamicParameters();
            p.Add("BeginDateTime", begin);
            p.Add("EndDateTime", end);
            //create connection using string
            using (var connection = new MySqlConnection(this.connectionString))
            {
                //format for Dapper call: stored procedure name, type to create, command type (always should look like this)
                data = connection.Query<cipprocessdata>("GetDataByDateTime",
                    p,
                    commandType: System.Data.CommandType.StoredProcedure);
                //always close the connection
                connection.Close();
            }
            //return the data
            List<cipprocessdata> post = new List<cipprocessdata>();
            foreach (var item in data)
            {
                post.Add(item);
            }
            return post;
        }

        public override List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end)
        {
            //create data object for return
            IEnumerable<cipprocessdata> data;
            //move variables into the Dapper object
            var p = new DynamicParameters();
            p.Add("BeginDateTime", begin);
            p.Add("EndDateTime", end);
            //create connection using string
            using (var connection = new MySqlConnection(this.connectionString))
            {
                //format for Dapper call: stored procedure name, type to create, command type (always should look like this)
                data = connection.Query<cipprocessdata>("GetAveragesByDateTime",
                    p,
                    commandType: System.Data.CommandType.StoredProcedure);
                //always close the connection
                connection.Close();
            }
            //return the data
            List<cipprocessdata> post = new List<cipprocessdata>();
            foreach (var item in data)
            {
                post.Add(item);
            }
            return post;
        }

        public override List<cipprocessdata> GetMovingAveragesByDateTime(DateTime begin, DateTime end)
        {
            //create data object for return
            IEnumerable<cipprocessdata> data;
            //move variables into the Dapper object
            var p = new DynamicParameters();
            p.Add("BeginDateTime", begin);
            p.Add("EndDateTime", end);
            //create connection using string
            using (var connection = new MySqlConnection(this.connectionString))
            {
                //format for Dapper call: stored procedure name, type to create, command type (always should look like this)
                data = connection.Query<cipprocessdata>("GetMovingAveragesByDateTime",
                    p,
                    commandType: System.Data.CommandType.StoredProcedure);
                //always close the connection
                connection.Close();
            }
            //return the data
            List<cipprocessdata> post = new List<cipprocessdata>();
            foreach (var item in data)
            {
                post.Add(item);
            }
            return post;
        }
    }
}

    