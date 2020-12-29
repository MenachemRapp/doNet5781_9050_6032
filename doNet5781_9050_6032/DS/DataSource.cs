﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

namespace DS
{
    public static class DataSource
    {
        public static List<AdjacentStations> List;
        public static List<Bus> ListBus;
        public static List<BusOnTrip> ListBusOnTrip;
        public static List<Line> ListLine;
        public static List<LineStation> ListLineStation;
        public static List<LineTrip> ListLineTrip;
        public static List<Station> ListStation;
        public static List<Trip> ListTrip;
        public static List<User> ListUser;


        static DataSource()
        {
            InitAllLists();
        }
        static void InitAllLists()
        {
            ListBus = new List<Bus>
            {
                new Bus
                {
                    LicenseNum=12345678,
                    FromDate= DateTime.Today.AddYears(-3),
                    ToatalTrip=7500,
                    FuelRemain=350,
                    Status=BUS_STATUS.AVAILABLE


                }
            };
        }
    }
}
