﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = @" - .NET
                - Java
                - JavaScript";
            
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execução acabou. Pressione o ENTER para sair");
            Console.ReadLine();
        }
    }
}
