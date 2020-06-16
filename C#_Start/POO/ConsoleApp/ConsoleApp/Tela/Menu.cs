using System;
using System.Collections.Generic;
using System.Text;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    class Menu
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n  Utilizando programação funcional" +
                    "\n\n" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n      0 - Sair do programa" +
                    "\n      1 - Para Ler Arquivos" +
                    "\n      2 - Para executar a tabuada" +
                    "\n      3 - Calcular média de alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("==== Opção Ler Arquivos ====");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n============================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("==== Opção tabuada ====");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n============================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();

                    Console.WriteLine("\n============================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente");
                }
            }
        }
    }
}
