using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//dapper serves the function of mapping
using Dapper;
//mysqlclient administrates the connection string
using MySql.Data.MySqlClient;

namespace MySQLDapperDebug.Models
{
    public class cipprocessdata
    {
        //primary key id
        public int id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateTransacted { get; set; }
        public DateTime DateCollected { get; set; }
        public float Fit1FlowRate { get; set; }
        public float Lt1Gallons {get;set;}
        public float Lt2Gallons {get;set;}
        public float Pt1Pressure {get;set;}
        public float Pt2Pressure {get;set;}
        public float Pt1Speed {get;set;}
        public float Pt2Speed {get;set;}
        public float Tt1Temperature {get;set;}
        public float Tt2Temperature {get;set;}
        public float Tt3Temperature {get;set;}
    }
}