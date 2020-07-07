using System;

namespace CalApp
{
    class Program
    {

        public static float Calc(string operation, float value1, float value2)
        {
            float result = 0;
            if (operation == "+")
            {

                result = value1 + value2;

            }
            else if (operation == "-")
            {

                result = value1 - value2;

            }
            else if (operation == "*")
            {

                result = value1 * value2;

            }
            else if (operation == "/")
            {

                result = value1 / value2;

            }

            return result;

        }

        public static void start()
        {
            Console.WriteLine("Enter the operator: to add(+), subtract(-), multiply(*) and divide(/)");
            Console.WriteLine(" ");
            Console.Write("Which operation do you want? ");

            string operation = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter with the 1º value: ");
            float value1 = Convert.ToSingle(((Console.ReadLine())));
            Console.WriteLine(" ");

            Console.Write("Enter with the 2º value: ");
            float value2 = Convert.ToSingle(((Console.ReadLine())));
            Console.WriteLine(" ");

            //Calling operations

            if (operation == "+")
            {
                Console.WriteLine("This is the result: " + Calc(operation, value1, value2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("This is the result: " + Calc(operation, value1, value2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("This is the result: " + Calc(operation, value1, value2));
            }

            else if (operation == "/")
            {
                Console.WriteLine("This is the result: " + Calc(operation, value1, value2));
            } 
            else
            {
                Console.WriteLine("Please enter valid value");
                start();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("====================Calc APP====================");
            Console.WriteLine(" ");

            start();


            while (true)
            {
                string response = "Y";
                Console.WriteLine("Do you want to do another calculation? YES(Y) or NO(N)");
                response = Console.ReadLine();

                if (response == "N")
                {

                    break;
                }
                else if(response == "Y" )
                {
                    start();
                }
                else
                {
                    Console.WriteLine("Is not valid value");
                }


            }
            Console.WriteLine("The End");

      
            
        }
    }
}
