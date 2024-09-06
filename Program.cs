using System.Diagnostics.Metrics;

namespace Part_5_If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int option;
                do
                {
                    Console.WriteLine("Hello, Please enter the number to access each program below!");
                    Console.WriteLine("1. Compass Bearing 2. Parking Garage Cost 3. Hurricane");
                }
                while (!int.TryParse(Console.ReadLine(), out option));
                if (option == 1)
                {
                    Compass();
                }
                Console.WriteLine("(Enter \"End\" to quit)");
            }
            while (Console.ReadLine() != "End");
            Environment.Exit(0);
        }
        public static void Parking()
        {
            Console.WriteLine("Please Enter the time (in minutes) you have been parking!(Do not include the unit)");
            int minute;
            if (int.TryParse(Console.ReadLine(), out minute))
            {

            }
            else 
            { 
                return;
            }
        }
            public static void Compass()
        {
            Console.WriteLine("Please Enter an angle (in degrees)!(Do not include the unit)");
            int angle;
            if (int.TryParse(Console.ReadLine(), out angle))
            {
                angle = angle % 360;
                if (angle < 0)
                {
                    angle += 360;
                }
                //Console.WriteLine(angle);

                if (angle <= 225 && angle >= 135)
                {
                    Console.WriteLine("The direction is SOUTH");
                }
                else if (angle < 315 && angle > 225)
                {
                    Console.WriteLine("The direction is WEST");
                }
                else if (angle < 135 && angle > 45)
                {
                    Console.WriteLine("The direction is EAST");
                }
                else if (angle <= 45 || angle >= 315)
                {
                    Console.WriteLine("The direction is NORTH");
                }
            }
            else { return; }

        }
    }
}
