﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace targil3B
{
    /// <summary>
    /// Interaction logic for BusProprtiesWindow.xaml
    /// </summary>
    public partial class BusProprtiesWindow : Window
    {
        Bus myBus;
        public BusProprtiesWindow(Bus bus)
        {
            InitializeComponent();
            txtCirculat.Content = bus.Aliya;
            txtRegestration.Content = bus.str_registration();
            txtMileage.Content = bus.Kilometer_total;
            ShowMaintaineDate(bus);
            ShowMaintaineMileage(bus);
            ShowRefuelMileage(bus);
            ShowStatus(bus);

            myBus = bus;

            MaintainClickedEvent += ShowMaintaineDate;
            MaintainClickedEvent += ShowMaintaineMileage;
            MaintainClickedEvent += ShowStatus;
            RefuelClickedEvent += ShowRefuelMileage;
            RefuelClickedEvent += ShowStatus;

            
        }

        private void ShowStatus(Bus bus)
        {
            txtStatus.Content= bus.bus_status.ToString();
        }
                

        private void ShowRefuelMileage(Bus bus)
        {
            txtRefuel.Content = bus.Kilometer_fuel;
        }

        private void ShowMaintaineMileage(Bus bus)
        {
            txtMaintMile.Content = bus.Kilometer_maintanence;
        }
        private void ShowMaintaineDate(Bus bus)
        {
            txtMaintDate.Content = bus.Maintanence_date;
        }

        private void RefuelClicked(object sender, RoutedEventArgs e)
        {
            this.myBus.refuel();
            if (RefuelClickedEvent!=null)
            {
                RefuelClickedEvent(myBus);
            }
                       
        }

        private void MaitainClicked(object sender, RoutedEventArgs e)
        {
            this.myBus.maintain();
            if (MaintainClickedEvent!=null)
            {
                MaintainClickedEvent(myBus);
            }
            

        }
        public delegate void ButtonClickedHandler(Bus bus);
        public event ButtonClickedHandler MaintainClickedEvent;
        public event ButtonClickedHandler RefuelClickedEvent;
                       
    }

}
