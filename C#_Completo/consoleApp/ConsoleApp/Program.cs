using System;
using System.Collections.Generic;
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

        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq"+ numeroArquivo +".txt";
            Console.WriteLine("============Lendo arquivo===========\n" + arquivoComCaminho + "\n==============================");
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
                LerArquivos(numeroArquivo + 1);
            }

        }

        private static void  calcularMediaAluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno: " + nome);
            List<int> notas = new List<int>();

            int totalNotas = 0;

            for(int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);

            }


            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é: " + media);

            Console.WriteLine("Suas notas são");
            foreach(int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }

        }

        private static void Menu()
        {
            while (true)
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

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    Console.WriteLine("====================Opção Ler Arquivos====================");
                    LerArquivos(1);
                    Console.WriteLine("===============================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==================Opção Tabuada===================");
                    Console.WriteLine("Digite o numero que deseja calcular a tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.WriteLine("===============================================================");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============================================");
                    calcularMediaAluno();
                    Console.WriteLine("============================================");
                }
                else
                {
                    Console.WriteLine("Opção invalida digite novamente");
                }
            }
        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
