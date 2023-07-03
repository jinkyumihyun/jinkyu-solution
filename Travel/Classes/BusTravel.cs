﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Interfaces;

namespace Travel.Classes
{
    public class BusTravel : ITravel
    {
        public void GotoAirport() => Console.WriteLine("Traveler is going to Airport by bus.");
    }
}
