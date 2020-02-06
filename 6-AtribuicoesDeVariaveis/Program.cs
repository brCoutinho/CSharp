using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 23;
            int idadeThiago = idade;

            idade = 20;

            Console.WriteLine(idadeThiago);


            Console.ReadLine();
        }
    }
}
