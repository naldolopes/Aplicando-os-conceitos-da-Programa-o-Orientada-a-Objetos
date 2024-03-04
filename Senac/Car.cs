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
