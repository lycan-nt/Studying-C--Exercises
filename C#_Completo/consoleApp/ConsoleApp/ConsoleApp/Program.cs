using System;
using System.IO;

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
            Console.WriteLine("============================== Tabuada do "+ numero +" =================================");

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }

            Console.WriteLine("===============================================================");
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq"+ numeroArquivo +".txt";
            if(File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";

            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }

        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        static void Main(string[] args)
        {
            while(true)
            {
                string mensagem = "Bem vindo ao ultilitarios APP" +
                    "\n Digite uma das opção a baixo: " +
                    "\n " +
                    "\n    0 - Sair Do Prgrama" +
                    "\n    1 - Ler Arquivos" +
                    "\n    2 - Tabuada" +
                    "\n    3 - Calcular Media";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair");
               
                if(SAIDA_PROGRAMA == valor)
                {
                    break;
                } else if(valor == LER_ARQUIVO)
                {
                    Console.WriteLine("====================Opção Ler Arquivos====================");
                    LerArquivo(1);
                } else if(valor == TABUADA)
                {
                    Console.WriteLine("==================Opção Tabuada===================");
                    Console.WriteLine("Digite o numero que deseja calcular a tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                } else if(valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("Falta Implementar o calculo da média");
                } else
                {
                    Console.WriteLine("Opção invalida digite novamente");
                }
            }

        }
    }
}
