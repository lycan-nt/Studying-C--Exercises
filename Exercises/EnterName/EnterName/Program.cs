using System;

namespace EnterName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================Enter Name======================================");
            Console.WriteLine("Whats your name?");

            string name = Console.ReadLine();

            Console.WriteLine("You name is: " + name);
        }
    }
}
