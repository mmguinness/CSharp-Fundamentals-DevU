using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Giveaway");
            //Console.Write("Choose a door: 1, 2 or 3: ");
            //string userValue = Console.ReadLine();

            //string message;

            //if (userValue == "1")
            //    message = "You won a new cat!";
            //else if (userValue == "2")
            //    message = "You won a new dog!";
            //else if (userValue == "3")
            //    message = "You won a new goat!";
            //else
            //    message = "Sorry, we didn't understand!";

            //Console.WriteLine(message);
            //Console.ReadLine();

            //Conditional Operator
            Console.WriteLine("Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Boat" : "piece of nothing-pie";
            //Console.Write("You won a  ");
            //Console.Write(message);
            //Console.Write(".");

            Console.WriteLine("You entered a {0}. Therefore you won a {1}.", userValue, message);
            Console.ReadLine();

            
        }
    }
}

