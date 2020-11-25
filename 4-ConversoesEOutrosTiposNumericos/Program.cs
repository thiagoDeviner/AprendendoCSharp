using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4.");

            double salario = 1200.50;
            
            // o int é uma variável que suporta até 32 bits
            double salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de variávelque suporta até 32 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável que suporta até 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // O float é um tipo de variável que suporta
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou. Pressione ENTER para sair.");
            Console.ReadLine();
        }
    }
}
