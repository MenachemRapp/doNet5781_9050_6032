﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public class BusStopLine 
    {
        public BusStop Stop { get; set; }
        public double Distance { get; set; }
        public TimeSpan Zman { get; set; }

        public BusStopLine(BusStop myBusStop, double myDistance, TimeSpan myZman)
        {
            Stop = new BusStop(myBusStop);
            Distance = myDistance;
            Zman = myZman;
        }


        public override string ToString()
        {
            String result =  base.ToString();
            result += String.Format(" Distance: {0}, Zman {1}", Distance, Zman);
            return result;
        }
    }
}
