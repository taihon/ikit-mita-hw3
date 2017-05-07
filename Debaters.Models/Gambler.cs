﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debaters.Models
{
    public abstract class Gambler
    {
        public readonly string Name;
        public int Score { get; internal set; }
        public Gambler(string name)
        {
            Name = name;
        }
        public abstract void FetchNewNumber(object sender, NewNumbertronNumberArgs args);
    }
}
