using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAcquisitionSystem.Models
{
    public class CipDataCollection
    {
        public int ID { get; set; }
        public DateTime DateTransacted { get; set; }
        public DateTime DateCollected { get; set; }
        public DateTime DateCreated { get; set; }
        public double Fit1FlowRate { get; set; }
        public double Lt1Gallons { get; set; }
        public double Lt2Gallons { get; set; }
        public double Pt1Pressure { get; set; }
        public double Pt2Pressure { get; set; }
        public double P1Speed { get; set; }
        public double P2Speed { get; set; }
        public double Tt1Temperature { get; set; }
        public double Tt2Temperature { get; set; }
        public double Tt3Temperature { get; set; }
    }
}