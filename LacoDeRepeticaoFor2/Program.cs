using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto Laço de Repetição For 2");

            for (int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna <= linha; coluna++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Fim da execução. Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
