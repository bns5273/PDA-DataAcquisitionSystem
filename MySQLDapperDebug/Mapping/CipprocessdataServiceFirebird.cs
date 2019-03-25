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
                                    "Database=c:/data/TEST.fdb;" +
                                    "DataSource=localhost;" +
                                    "Port=3050;";

        //select all records from the database
        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (FbConnection connection = new FbConnection(connectionString))
            {

                connection.Open();

                // this is different due to the selectable procedure concept

                String query = String.Format("select * from GetDataByDateTime('{0}', '{1}');",
                    begin.ToString("yyyy-MM-dd HH:mm:ss"),
                    end.ToString("yyyy-MM-dd HH:mm:ss"));
                data = connection.Query<cipprocessdata>(query).ToList();

                // "select * from GetDataByDateTime(@param2, @param2)"
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

                // this is different due to the selectable procedure concept

                String query = String.Format("select * from GetAverageByDateTime('{0}', '{1}');",
                    begin.ToString("yyyy-MM-dd HH:mm:ss"),
                    end.ToString("yyyy-MM-dd HH:mm:ss"));
                data = connection.Query<cipprocessdata>(query).ToList();

                // "select * from GetDataByDateTime(@param2, @param2)"
                connection.Close();
            }

            return data;
        }
    }
}
