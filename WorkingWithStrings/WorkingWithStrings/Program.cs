using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life.";

            //string myString = "What if I need a \nnewline?";

            //string myString = "Go to your c:\\ drive.";
            //string myString = @"Go to your c:\ drive.";

            //string myString = String.Format("{0} = {0}", "First", "Second");

            //string myString = string.Format("{0:C}", 123.45);

            //string myString = String.Format("{0:N}", 123456789);

            //string myString = string.Format("Percentage: {0:P}", .25);

            //Custom format
            //string myString = string.Format("Phone number: {0:(###) ### ####}", 8512211221);

            //string myString = " Nothing compares to you  ";
            //myString = myString.Substring(9, 8);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(9, 9);
            //myString = String.Format(
            //    "Length before trim: {0} -- Length after trim: {1}",
            //    myString.Length,
            //    myString.Trim().Length
            //    );

            //Takes up a lot of memory
            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            //More efficient way to build strings
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}

