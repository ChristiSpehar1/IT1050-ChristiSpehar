using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //The array access expressions to access each of the elements in p are _______, _______,_______ and ______.
            //p[0], p[1], p[2], p[3]

            string[] month = new string[12];
            month[0] = "January";
            month[1] = "February";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";


            Console.WriteLine($"Months: ");
            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine(month[i]);
            }

            Console.WriteLine("Seasons: ");
            string[] seasons =
            {
                "Winter",
                "Spring",
                "Summer",
                "Fall" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            int[] randomNumber = new int[1000];
            Random random = new Random();
            for (int y = 0; y < randomNumber.Length; y++)
            { 
                randomNumber[y] = random.Next(0, 100); 
            }
            foreach (int y in randomNumber)
            {
                Console.WriteLine(y.ToString());
            }
            string[] names =
                { 
                "Al Dente",
                "Anna Graham", 
                "Earle Bird", 
                "Ginger Rayle", 
                "Iona Ford" };

            
            //for (int r = 0; r < names.Length; r++)
                foreach (string name in names)
            {
                    Console.WriteLine(name);
            }

            

        }
    }
}
