﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Sua idade é " + idade "!");

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");
            Console.WriteLine("Execução finalizada. Aperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
