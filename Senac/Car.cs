﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac
{
    public class Car: Vehicle
    {
        public Car(double dailyRate): base(dailyRate)
        {
        }

        public override double CalculateTotalAmount(int numDays)
        {
            return DailyRate * numDays;
        }
    }
    
}