using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySQLDapperDebug.Models;
using MySql.Data;

namespace MySQLDapperDebug.Mapping
{
    public abstract class cipprocessdataDAO
    {
        // get all fields of rows between the timestamps
        public abstract List<cipprocessdata> GetDataByDateTime(DateTime begin, DateTime end);

        // get averages of all relevant fields between the timestamp
        public abstract List<cipprocessdata> GetAveragesByDateTime(DateTime begin, DateTime end);

        // get moving average of all relevant fields between the timestamps
        public abstract List<cipprocessdata> GetMovingAveragesByDateTime(DateTime begin, DateTime end);
    }
}