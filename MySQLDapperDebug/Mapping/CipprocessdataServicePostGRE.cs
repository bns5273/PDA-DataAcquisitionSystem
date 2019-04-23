using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using MySQLDapperDebug.Models;
using Dapper;

namespace MySQLDapperDebug.Mapping
{
    public class CipprocessdataServicePostGRE : cipprocessdataDAO
    {
        private readonly string connectionString = 
            "Server=10.0.1.239;" +
            "Port=5432;" +
            "Database=postgres;" +
            "User Id=postgres;" +
            "Password=root;";


        public override List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                data = connection.Query<cipprocessdata>("\"GetDataByDateTime\"",
                    new { BeginDateTime = begin, EndDateTime = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                connection.Close();
            }

            return data;
        }

        public override List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                data = connection.Query<cipprocessdata>("\"GetAveragesByDateTime\"",
                    new { BeginDateTime = begin, EndDateTime = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                connection.Close();
            }

            return data;
        }

        public override List<cipprocessdata> GetMovingAveragesByDateTime(DateTime begin, DateTime end)
        {
            List<cipprocessdata> data = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                data = connection.Query<cipprocessdata>("\"GetMovingAveragesByDateTime\"",
                    new { BeginDateTime = begin, EndDateTime = end },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
                connection.Close();
            }

            return data;
        }
    }
}
