using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySQLDapperDebug.Mapping
{
    public class cipprocessdataDAOfactory
    { 
        //factory class with single method to return user DAO
        public static cipprocessdataDAO getDAO(String type)
        {
            //assuming mySQL is the default database, return mySQL if neither firebird nor postgre are specified
            if(type.ToLower().Equals("firebird"))
            {
                return new CipprocessdataServiceFirebird();
            }
            else if(type.ToLower().Equals("postgre"))
            {
                return new CipprocessdataServicePostGRE();
            }
            else return new CipprocessdataServiceMySQL();
        }

    }
}