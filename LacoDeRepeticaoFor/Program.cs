using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do Projeto Laço de Repetição For");

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("A execução acabou. Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
