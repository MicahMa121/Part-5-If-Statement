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
                switch (option)
                {
                    case 1:
                        Compass();
                        break;
                    case 2:
                        Parking();
                        break;
                    case 3:
                        Hurricane();
                        break;
                }
                Console.WriteLine("(Enter \"End\" to quit)");
            }
            while (Console.ReadLine() != "End");
            Environment.Exit(0);
        }
        public static void Hurricane()
        {
            Console.WriteLine("Please pick a hurricane category!(Enter an integer from 1-5)");
            int category;
            if (int.TryParse(Console.ReadLine(), out category))
            {
                switch (category)
                {
                    case 1:
                        Console.WriteLine("Hurricane Category 1:\t74-95mph\t64-82kt\t119-153km\\h\t");
                        break;
                    case 2:
                        Console.WriteLine("Hurricane Category 2:\t96-110mph\t83-95kt\t154-177km\\h");
                        break;
                    case 3:
                        Console.WriteLine("Hurricane Category 3:\t111-129mph\t96-112kt\t178-208km\\h");
                        break;
                    case 4:
                        Console.WriteLine("Hurricane Category 4:\t130-156mph\t113-136kt\t209-251km\\h");
                        break;
                    case 5:
                        Console.WriteLine("Hurricane Category 5:\t>157mph\t>137kt\t>252km\\h");
                        break;
                }
            }
            else { return; }
        }
        public static void Parking()
        {
            Console.WriteLine("Please enter the time (in minutes) you have been parking!(Do not include the unit)");
            int minute;
            if (int.TryParse(Console.ReadLine(), out minute))
            {
                if (minute > 0 && minute <= 60)
                {
                    Console.WriteLine("Your parking fee is $4.00!");
                }
                else if (minute>60)
                {
                    int fee = 4;
                    fee += Convert.ToInt16(2 * (Math.Ceiling((double)minute / 60)-1));
                    if (fee > 20) 
                    {
                        fee = 20;
                    }
                    Console.WriteLine("Your parking fee is "+fee.ToString("$0.00")+"!");
                }
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
