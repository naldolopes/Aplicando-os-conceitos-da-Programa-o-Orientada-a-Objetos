using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac
{
    public abstract class Vehicle
    {
        protected double DailyRate { get; set; } 

        public Vehicle(double dailyRate)
        {
            DailyRate = dailyRate;
        }

        public abstract double CalculateTotalAmount(int numDays);
    }
}
