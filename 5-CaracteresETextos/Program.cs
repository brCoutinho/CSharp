using System;
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
            char primeiraLetra = 'A';

            primeiraLetra = (char)65;

            Console.WriteLine(primeiraLetra);

            string titulo = "Thiago Coutinho, Dev " + 1997;
            Console.WriteLine(titulo);

            string linguagensEstudadas =
 @"- .NET
- Java
- Javascript";

            Console.WriteLine(linguagensEstudadas);

            Console.ReadLine();
        }
    }
}
