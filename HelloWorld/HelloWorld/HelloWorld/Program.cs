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
            Console.WriteLine("Soma: X + Y = " + (x + y)); // Print the value of x + y 

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

            //Entrada de dados

            Console.WriteLine("Enter username: ");
            String userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age: " + userAge);

            //Booleano

            bool isCharpFul = true;
            bool isFishTasty = false;
            Console.WriteLine(isCharpFul);
            Console.WriteLine(isFishTasty);

            int num1 = 10;
            int num2 = 9;
            Console.WriteLine(num1 > num2);

            //if and else...

            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int ifNum1 = 20;
            int ifNum2 = 10;
            if (ifNum1 > ifNum2)
            {
                Console.WriteLine("ifNum1 is greater than ifNum2");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("God Day!");
            }
            else
            {
                Console.WriteLine("God nigth!");
            }

            string result = (time > 18) ? "God nigth" : "God day!";
            Console.WriteLine(result);

            //Switch

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Moonday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //While Loop

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int i2 = 1;
            do
            {
                Console.WriteLine(i2);
            } while (i2 > 1);

            //break

            for(i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }

        }

    }
}
