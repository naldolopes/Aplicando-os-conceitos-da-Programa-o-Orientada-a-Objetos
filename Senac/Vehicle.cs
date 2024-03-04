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
