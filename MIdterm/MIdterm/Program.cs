using System;

namespace MIdterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // (2)

            // The 3 types of of control structures are:
            // 1) sequential: line-by-line execution to where statements are executed in the same order that they appear in the program.
            // 2) selection: allows one statement to be excuted if the condition is true and another set of action to be excuted if the statement is false.
            // 3) iteration: statement is executed until the program reaches a certain point. EXAMPLE... while, for, dowhile.

            // (3)

            //for (int i = 0; i < 150; i--)
            //{
            //    Console.WriteLine("{0}", i);
            //}
            //Console.ReadLine();

            // (4)

            int j = 2;            
            while (j < 128)
            {
                Console.WriteLine("[" + j + "]");
                j = j * 2;                              
            }

            // (5)
          
            int r;
            string output = "";
            for (r = 49; r > 0; r--)
            {
                output = output + r + ", ";                                             
                                  
            }
            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);

            //6

            int p = 1;
            
            while (p < 22)

            {
                Console.Write(p + " ");             
                p = p + 2;                             
            }

            //7

            //int n = 8;
            //int i = 10; // initialize
            //do
            //{
            //    Console.Write("*");
            //    i++; // update!
            //} while (i < n); // test condition



            // the output without a modification is '*'
            // it would not output anything being a while loop alone.

            //8

            Console.WriteLine(Convert.ToInt32(true));
            Console.WriteLine(Convert.ToInt32(false));
            bool icyRain = false;
            bool tornadoWarning = false;

            Console.WriteLine("Icy rain" + Convert.ToInt32(icyRain));
            Console.WriteLine("Tornado Warning" + Convert.ToInt32(tornadoWarning));

           

            Console.WriteLine("0>1");
            if (Convert.ToInt32(true) > Convert.ToInt32(false));
            {
                Console.WriteLine("Let’s go outside!");
            }

            



        }
    }
}
