using CarShowroom.Models;
using System.Net.Mail;

namespace CarShowroom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Customer currentCustomer = new Customer("Ivan", new MailAddress("ivan@gmail.com"), new List<string> { "BMW", "Ferrari", "Lamborghini" }, 400000);
            List <Car> carDatabase = new List<Car> {
                new Car("Ferrari", "Daytona SP3", "Italy", 2022, new Features("V12", 829, "Gasoline"), 3000000),
                new Car("Ferrari", "LaFerrari", "Italy", 2013, new Features("V12", 950, "Gasoline"), 5000000),
                new Car("BMW", "M5", "Germany", 2020, new Features("V8", 635, "Gasoline"), 200000),
                new Car("Lamborghini", "Sian", "Italy", 2020, new Features("V12", 635, "Gasoline"), 2000),
            };

            AutoMatcher matcher = new AutoMatcher();
            var matchedCars = matcher.MatchCars(currentCustomer, carDatabase);

            Console.WriteLine("Matched Cars for " + currentCustomer.Name + ":");
            foreach (var car in matchedCars)
            {
                Console.WriteLine(car);
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}