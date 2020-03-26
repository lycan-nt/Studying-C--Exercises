using System;

namespace Methodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

class Program
{
    static void MyMethod()
    {
        //Code
    }



}



//Outputs "I just got executad"

//=========================================================================================================
 
//Parametros


class Program2
{
    static void MyMethod(string fname)
    {
        Console.WriteLine("fname" + "D. Santos");
    }

    static void Main(string[] args)
    {
        MyMethod("Felipe");
        MyMethod("Marcella");
        MyMethod("Yuno");
        MyMethod("Floop");
    }

}

