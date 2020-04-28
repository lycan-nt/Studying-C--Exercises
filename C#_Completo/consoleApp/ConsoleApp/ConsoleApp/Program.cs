using System;

namespace ConsoleApp
{

    class Program
    {

        public int CalcularSoma2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;           
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("===============================================================");

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }

            Console.WriteLine("===============================================================");
        }
        static void Main(string[] args)
        {
            int retorno = CalcularSoma();

            Console.WriteLine(retorno);

            MostrarMensagemNaTela();

            Tabuada(10);

            Console.Read();
        }
    }
}
