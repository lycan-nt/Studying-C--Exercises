using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is comment

            string name = "Felipe D. Santos";
          
            Console.WriteLine("Hello World! " + name);

            int myNum = 10;
            myNum = 100; //myNum is now 100
            Console.WriteLine("Nota: " + myNum);

            int x = 5;
            int y = 5;
            Console.WriteLine("Soma: X + Y = " + ( x + y)); // Print the value of x + y 

            //Conversão implicita

            int myInt = 9;
            double myDooble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDooble);

            //Conversão Explicita

            myDooble = 9.5;
            myInt = (int)myDooble;

            Console.WriteLine(myDooble);
            Console.WriteLine(myInt);
        }
    }
}
