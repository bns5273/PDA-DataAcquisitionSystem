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
        private readonly string connectionString =
                                    "User=sysdba;" +
                                    "Password=masterkey;" +
                                    "Database=c:/db/data.fdb;" +
                                    "DataSource=localhost;" +
                                    "Port=3050;";

        //select all records from the database
        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (FbConnection connection = new FbConnection(connectionString))
            {

                connection.Open();

                // dapper nicely handles the selectable procedure concept under the hood!
                // this implementation does not build a query string and thus doesn't
                // risk injection attacks
                data = connection.Query<cipprocessdata>("GetDataByDateTime",
                    new { param1 = begin, param2 = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();

                connection.Close();
            }

            return data;
        }

        //select all points from one field
        public override List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (FbConnection connection = new FbConnection(connectionString))
            {

                connection.Open();

                data = connection.Query<cipprocessdata>("GetAveragesByDateTime",
                    new { param1 = begin, param2 = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                connection.Close();
            }

            return data;
        }

        public override List<cipprocessdata> GetMovingAveragesByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (FbConnection connection = new FbConnection(connectionString))
            {
                connection.Open();

                data = connection.Query<cipprocessdata>("GetMovingAveragesByDateTime",
                    new { param1 = begin, param2 = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                connection.Close();
            }

            return data;
        }
    }
}
