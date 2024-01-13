using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        private static object myName;
        private static object myLocation;
        private static object currentDate;
        private static object numberOfDays;
        private static int width;
        private static int height;
        private static int woodLength;
        private static int glassArea;
        private static string widthString;
        private static string heightString;


        static void Main(string[] args)
        {


            myName = "Pumehana";

            myLocation = "Connecticut";

            Console.WriteLine("My name is " + myName + ".");
            Console.WriteLine("I live in " + myLocation + ".");

            currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine("Current date: " + currentDate);

            DateTime futurDate = Convert.ToDateTime("12/25/2024");
            DateTime TodayDate = DateTime.Now;
            numberOfDays = (futurDate - TodayDate).TotalDays.ToString("###");

            Console.WriteLine("Days Till Christmas: " + numberOfDays + " days left!");

            Console.WriteLine("Enter the width of the wood (in feet): ");
            widthString = Console.ReadLine();
            width = (int)double.Parse(widthString);
            Console.WriteLine("Enter the height of the wood (in feet): ");
            heightString = Console.ReadLine();
            height = (int)double.Parse(heightString);
            woodLength = (int)(2 * (width + height) * 3.25);
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();

        }


    }
}
