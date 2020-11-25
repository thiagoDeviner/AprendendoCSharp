using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto Laço de Repetição While");

            int contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.WriteLine("A execução acabou. Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
