using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // The if single-selection statement and the while repetition statement are similar because they both go through atleast one input and they both can either take an action or ignore the action given.
            //The if single-selection statement and the while repetition statement differ, because the if statement doesn't loop like the while statement would. The while statement will loop as many times or infinitely as long as the parameters allow it to.


            //Speed Limit
            int speedLimit;
            int speed;
            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            //True and False
            Console.WriteLine("Convert.ToInt (true) : " + Convert.ToInt32(true));
            Console.WriteLine("Convert.ToInt (false): " + Convert.ToInt32(false));

            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine("Convert.ToInt32 (true):" + Convert.ToInt32(isTrue));
            Console.WriteLine("Convert.ToInt32 (false):" + Convert.ToInt32(isFalse));

            Console.WriteLine("1>0");
            if (Convert.ToInt32(true) > Convert.ToInt32(false))
            {
                Console.WriteLine("It is True!");
            }
            Console.WriteLine("0>1");
            if (Convert.ToInt32(false) > Convert.ToInt32(true))
            {
                Console.WriteLine("It is True!");
            }
            Console.WriteLine("It is False!");

            //Temperature
            int Celsius;
            int Fahrenheit;

            Console.WriteLine("Enter the Temperature in Fahrenheit : ");
            Fahrenheit = int.Parse(Console.ReadLine());
            Celsius = (Fahrenheit * 9) / 5 + 32;
            Console.WriteLine("Temperature in Celsius : " + Celsius);
            Console.ReadLine();

            if (Fahrenheit > 90)
            {
                Console.WriteLine("It is hot.");
            }
            if (Fahrenheit < 40)
            {
                Console.WriteLine("It is cold.");
            }

            //While Loops

            int x = 1;
            while (x < 11)
            {
                Console.WriteLine(x);
                x = x + 1;
            }

            int y = 60;
            while (y > 19)
            {
                Console.WriteLine(y);
                y = y - 5;
            }

            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i)
                i = i + 2;
            }





















        }
    }
}
