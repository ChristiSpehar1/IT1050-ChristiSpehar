using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Initial value of the control variable: determines the starting value of the control
            // Control variable: This is the loop counter
            // Increment/Decrement: how much the control variable adds or subtracts
            // Loop-continuation condition: determines if looping should continue

            // A while statement and a repitition statement are similar, because they both can loop. A while statement will loop until something becomes false, but a repetition statement will loop until it is true.

            // A do while loop should be used when you don't know how many times something will loop. If you just used a while loop, it could be stuck in an infinite loop.

            int i = 0;
            while (i < 101)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("It's even");
                }
                else
                {
                    Console.WriteLine("It's odd");
                }
                Console.WriteLine(i);
                i++;
            }
            int temp = 0;
            Console.Write("Please enter a temperature: ");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp <= 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temp <= 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temp <= 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp <= 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp <= 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp <= 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp <= 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp <= 90)
            {
                Console.WriteLine("Fish");
               
            }
           
            else switch (temp)
            {
                default:
                    Console.WriteLine("bug");
                        break;
            }

            //int p = 10;
            //while (p < 21)
            //{
            //    Console.WriteLine(p);
            //}

            // (I had to change the int variable.)

            // 10 keeps on looping in this code.
            // no parameters or counters were ever set.
            // A solution to this code would be:
            int p = 10;
            while (p < 21)
            {
                Console.WriteLine(p);
                p++;
            }

            //for (int y = 0; y < 101; y++)
            //    Console.WriteLine(y);
            //Console.WriteLine("********");

            // the asterisks come after the 100
            // A solution to this code can be:

            for (int y = 0; y < 101; y++)
                if (y % 1 == 0)
                    
            
                {
                    Console.WriteLine(y);
                    Console.WriteLine("********");
                }
                
            





        }
    }
    }



