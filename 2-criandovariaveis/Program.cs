using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");

            int idade;
            idade = 23;

            Console.WriteLine("Sua idade é "+ idade);

            idade += idade;

            Console.WriteLine(idade);



            Console.WriteLine("Execução Finalizada. Tecle Enter para sair");

            Console.ReadLine();
        }
    }
}
