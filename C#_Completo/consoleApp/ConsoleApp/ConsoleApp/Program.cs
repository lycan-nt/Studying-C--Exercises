﻿using System;
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
            Console.WriteLine("===============================================================");

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
        static void Main(string[] args)
        {
            LerArquivo(1);
        }
    }
}
