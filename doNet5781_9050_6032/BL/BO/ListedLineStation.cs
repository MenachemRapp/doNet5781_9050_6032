﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class ListedLineStation
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public double Distance { get; set; }
        public TimeSpan Time { get; set; }
        public bool ThereIsTimeAndDistance { get; set; }

        public override string ToString() => this.ToStringProperty();

    }
}
