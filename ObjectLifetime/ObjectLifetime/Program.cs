using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car myThirdCar = new Car("Skoda", "Superb", "Yellow", 222);

            //myCar.Make = "Fabia";
            //myCar.Model = "Skoda";
            //myCar.Year = 2011;
            //myCar.Color = "Silver";

            //Car myOtherCar;
            //myOtherCar = myCar;

            //Console.WriteLine("{0}, {1}, {2}, {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color);

            //myOtherCar.Model = "Toyota";

            Console.WriteLine("{0}, {1}, {2}, {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //myOtherCar = null;

            //Console.WriteLine("{0}, {1}, {2}, {3}",
            //    myCar.Make,
            //    myCar.Model,
            //    myCar.Year,
            //    myCar.Color);

            //myCar = null;

            //Console.WriteLine("{0}, {1}, {2}, {3}",
            //    myCar.Make,
            //    myCar.Model,
            //    myCar.Year,
            //    myCar.Color);

            Console.WriteLine("{0}, {1}, {2}, {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);

            Car.MyMethod();

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model, string color, int year)
        {
            this.Make = make;
            Model = model;
            Color = color;
            Year = year;
        }

        public static void MyMethod()
        {
            Console.WriteLine("Called the static method");
        }
    }

}

