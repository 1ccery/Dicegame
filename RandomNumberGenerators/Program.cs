using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1,11);
            Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");
            //programm kontrollib kas genereeritud nuber on suurem kui 5
            //kui genereeritud mumber on suurem, kui 5 iis programm kuvab
            //juhuslik number on {myRandomNumber} see on suurem kui 5

            

            if (myRandomNumber > 5)
            {
                Console.WriteLine($"sinu kuvatud {myRandomNumber} on suurem kui 5");
            }
            else if (myRandomNumber < 5)
            {
                Console.WriteLine($"su {myRandomNumber} on väiksem kui viis");

            }
            else if (myRandomNumber == 5)
            {
                Console.WriteLine($"su {myRandomNumber} on 5");

            }
        }
    }
}
