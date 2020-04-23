using System;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Car
    {
        String color = "Black";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj2.color);
        }
    }

    class MyClass
    {
        String color = "Red";
        int maxSped = 200;
        public void fullController()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            MyClass ObjC = new MyClass();
            Console.WriteLine(ObjC.color);
            Console.WriteLine(ObjC.maxSped);
        }
    }

    //Create a car class
    class Car1
    {
        public string model; //Create a fild

        //Create a class constructor for de class car
        public Car1()
        {
            model = "Mustang"; //Set the initial value for model
        }

        static void Main(string [] args)
        {
            Car1 Ford = new Car1(); //Create  an object of the  car Class  (this will call the constructor)
            Console.WriteLine(Ford.model);
        }
    }
}
