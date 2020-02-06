using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeThiago = 13;
            int quantidadePessoas = 2;

            if (idadeThiago > 18)
            {
                Console.WriteLine("Maior de Idade, pode entrar!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Menor de Idade, porém acompanhado");
                }
                else
                {
                    Console.WriteLine("Menor de Idade, não pode entrar!");
                }
                
            }

            Console.ReadLine();
        }
    }
}
