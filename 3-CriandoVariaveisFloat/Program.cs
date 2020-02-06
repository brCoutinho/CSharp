using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variáveis Float");

            double salario;

            salario = 3000.00;
            double numeroaaleatorio;
            numeroaaleatorio = 15.0 / 2;

            Console.WriteLine(numeroaaleatorio);

            Console.WriteLine("Seu salário é " + salario);

            Console.WriteLine("Execução Finalizada. Tecle Enter para sair");

            Console.ReadLine();
        }
    }
}
