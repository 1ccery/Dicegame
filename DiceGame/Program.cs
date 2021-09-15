using System;

namespace DiceGame
{
    class Program
    {






        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random rnd = new Random();

            string PlayerOne = "Adrian";
            string PlayerTwo = "Joosep";



            int JoueThrow = rnd.Next(1, 7);
            int PapsThrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw {JoueThrow}");
            Console.WriteLine($"{PlayerTwo} threw {PapsThrow}");




            if (JoueThrow > PapsThrow)
            {
                Console.WriteLine($"{PlayerOne} wins");
            }
            else if (JoueThrow < PapsThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins");

            }
            else
            {
                Console.WriteLine($"Draw try again");


            }



        }
    }
}




