/*
 * 
    Author: Reginaldo Lopes de Oliveira
    Date: 2020-09-20
    Description: This program calculates the total amount for a car and motorcycle rental for a given number of days.
 *   
 */

using Senac;
using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        // Car daily rate
        const double carDailyRate = 50.0;

        // Motorcycle daily rates
        const double motorcycleDailyRate = 25.0; 

        // Create a car object, and set the daily rate $50.0 dollars
        Car car = new Car(carDailyRate); 

        // Create a motorcycle object, and set the daily rate $25.0 dollars
        Motorcycle motorcycle = new Motorcycle(motorcycleDailyRate);

        // 10 days rental, use the CalculateTotalAmount method to calculate the total amount
        const int numDays = 10;

        // Calculate the total amount for the Car rental
        double totalAmountCar = car.CalculateTotalAmount(numDays);

        // Calculate the total amount for the Motorcycle rental
        double totalAmountMoto = motorcycle.CalculateTotalAmount(numDays);

        // Print the total amount for the car and motorcycle rental
        Console.WriteLine("Rental amount for the car and motorcycle");
        Console.WriteLine("=======================================");
        Console.WriteLine($"Number of days: {numDays}");
        Console.WriteLine($"Car daily rate: $ {carDailyRate}", CultureInfo.InvariantCulture);
        Console.WriteLine($"Motorcycle daily rate: $ {motorcycleDailyRate}", CultureInfo.InvariantCulture); 
        Console.WriteLine($"Total rental amount for the car for {numDays} days: $ {totalAmountCar}", CultureInfo.InvariantCulture);
        Console.WriteLine($"Total rental amount for the motorcycle for {numDays} days: $ {totalAmountMoto}", CultureInfo.InvariantCulture);
    }
}