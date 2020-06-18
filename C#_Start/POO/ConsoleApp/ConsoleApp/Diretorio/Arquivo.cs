﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = ConfigurationManager.AppSettings["caminho_arquivos"] + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("==== Lendo arquivo ====\n" + arquivoComCaminho + "\n=====");
            if (File.Exists(arquivoComCaminho))
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
            string arquivoComCaminho2 = ConfigurationManager.AppSettings["caminho_arquivos"] + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
