﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            Console.WriteLine("======== Calculo da tabuada do " + numero + "\n==========");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("==================");
        }
    }
}
