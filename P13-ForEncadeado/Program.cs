using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto P13 - For Encadeado");

            // *
            // **
            // ***
            // ****
            // ******

            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    if (contadorColuna >= contadorLinha)
                        break;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Fim da execução. Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
