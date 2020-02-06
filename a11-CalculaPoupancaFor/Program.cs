using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a11_CalculaPoupancaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Calcula Poupança");

            double valorInvestido = 1000;
             
            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }



            Console.ReadLine();
        }
    }
}
