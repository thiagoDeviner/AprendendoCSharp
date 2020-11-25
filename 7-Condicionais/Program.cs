using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int quantidadePessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João já possui mais de 18 anos e já pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui 18 anos mas está acompanhado. Então pode entrar!");
                }
                else
                {
                    Console.WriteLine("João não pode entrar. Ainda não tem 18 anos completos.");
                }
            }

            Console.WriteLine("A execução acabou. Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
