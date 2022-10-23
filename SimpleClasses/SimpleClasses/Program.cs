using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //setting properties
            myCar.Make = "Skoda";
            myCar.Model = "Fabia";
            myCar.Year = 2011;
            myCar.Color = "Champagne";

            //getting properties
            Console.WriteLine("{1}--{0}--{2}--{3}",
                myCar.Model,
                myCar.Make,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("Estimated Value: {0:C}", value);
            Console.WriteLine("Estimated Value: {0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
        }

        //Move this method to the Car class
        //private static decimal DetermineMarketValue(Car car)
        //{
        //    decimal carValue = 100.0M;
        //    //look up actual value instead of hardcoding
        //    return carValue;
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }
}

