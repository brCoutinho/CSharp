using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversaoOutrosTiposNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            long idade; //long é para números com mais de 32 bits
            idade = 1200000000000000000;

            float quantidade = 1.50f;

            Console.ReadLine();
        }
    }
}
