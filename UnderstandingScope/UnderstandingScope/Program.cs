using System;

namespace UnderstandingScope
{
    class Program
    {

        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                    Console.WriteLine(l);
                }
            }
            //i does not exist outside the for loop
            //Console.WriteLine(i);

            Console.WriteLine("Outside of the for loop: " + j);
            Console.WriteLine("Outside of the for loop: " + k);

            HelperMethod();


            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("From HelperMethod: " + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helpermethod());
            }

            private string helpermethod()
            {
                return "Hello World ;-)";
            }
        }
        
    }
}

