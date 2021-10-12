using System;

namespace Gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int gissaTal  = number.Next(1, 101);
            int Tal = 0;
            int Attempts = 0;
            Console.WriteLine("I am thinking of a number between 1 and 100, can you guess what it is?: ");
            
            while (Tal != gissaTal){
                Tal = Convert.ToInt32(Console.ReadLine());
                if (Tal < gissaTal)
                {
                Console.WriteLine("No, the number I am thinking of is higher than " + Tal + ". Can you guess what it is?");
                }
                else if (Tal > gissaTal)
                {
                Console.WriteLine("No, the number I am thinking of is lower than " + Tal + ". Can you guess what it is?");
                }
                Attempts++;
            }
            Console.WriteLine("Well done! The answer was " + gissaTal);
            Console.WriteLine("The number of attempts you made was:" + Attempts);
            Console.ReadKey(); 
        }
    }
}
