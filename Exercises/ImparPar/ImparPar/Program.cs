using System;

namespace ImparPar
{
    class Program
    {

        public static void ImparPar(int number)
        {

            int result = 0;

            if (number % 2 == 0)
            {
                result = number;
                Console.WriteLine(number + " é Par");
            } 
            else
            {
                result = number;
                Console.WriteLine(number + " é Impar");
            }

            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=================Impar or Par APP=================!");
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            ImparPar(number);

            Console.WriteLine("======================================");
            int program = 0;
            Console.WriteLine("Enter 1 for view other number");
            program = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (program == 1)
                {
                    Console.WriteLine("Please enter the number: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    ImparPar(number);
                }

                Console.WriteLine("Enter 1 for view other number");
                program = Convert.ToInt32(Console.ReadLine());

            } while (program == 1);
            
        }
    }
}
