using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirebirdSql.Data.FirebirdClient;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServiceFirebird : cipprocessdataDAO
    {
        private readonly string connectionString = "user=root;password=root;database=collectcipprocessdata;port=3050;DataSource=localhost;";

        public CipprocessdataServiceFirebird()
        {
            
        }

        //select all records from the database
        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            List<dynamic> data = null;
            
            // var p = new DynamicParameters();
            // p.Add("BeginDateTime", begin);
            // p.Add("EndDateTime", end);

            using (FbConnection connection = new FbConnection(connectionString))
            {
                // connection.Open();

                // this is different due to the selectable procedure concept
                data = connection.Query(
                    "select * from collectcipprocessdata(@begin, @end)",
                    new { begin, end }).ToList();
                    // commandType: System.Data.CommandType.Text).ToList();

                connection.Close();
            }
            //return the data
            List<cipprocessdata> post = new List<cipprocessdata>();
            foreach (var item in data)
            {
                cipprocessdata cip = (cipprocessdata)item;
                Console.WriteLine(cip.DateCollected);
                post.Add(cip);
            }
            return post;
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
