﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace BL
{
    sealed class SimulationTimer
    {
        static readonly SimulationTimer instance = new SimulationTimer();
        static SimulationTimer() { }// static ctor to ensure instance init is done just before first usage
        SimulationTimer() { } // default => private
        public static SimulationTimer Instance { get => instance; }// The public Instance property to use

        
        public Stopwatch stopwatch= new Stopwatch();
        
        
       
        public event EventHandler ValueChanged;
        TimeSpan simulationTime;
            
           
       public void run(TimeSpan startTime, int Rate)
        {
            stopwatch.Restart();
            while (stopwatch.IsRunning)
            {
                TimeSpan timerTime = TimeSpan.FromTicks(stopwatch.Elapsed.Ticks * Rate) + startTime;
                timerTime -= TimeSpan.FromDays(timerTime.Days);
                SimulationTime = timerTime;

                Thread.Sleep(1000);
            }


        }
        
        void OnValueChanged(ValueChangedEventArgs args)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, args);
            }
        }

        public TimeSpan SimulationTime
        {
            get { return simulationTime; }

            set
            {
                ValueChangedEventArgs args = new ValueChangedEventArgs(simulationTime, value);
                simulationTime = value;
                OnValueChanged(args);
            }
        }

       


    }
    public class ValueChangedEventArgs : EventArgs
    {
        public readonly TimeSpan OldValue, NewValue;

        public ValueChangedEventArgs(TimeSpan oldTemp, TimeSpan newTemp)
        {
            OldValue = oldTemp;
            NewValue = newTemp;
        }
    }
}
