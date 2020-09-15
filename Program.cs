using OO_Course.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;

namespace OO_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte {i}:");
                Console.Write("Pessoa física ou pessoa jurídica (f/j)? ");
                string tipo = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == "f")
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Pf(nome, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new Pj(nome, rendaAnual, numeroFuncionarios));
                }
            }

            Console.WriteLine("IMPOSTO PAGO: ");
            double sum = 0.0;
            foreach (Contribuinte com in list)
            {
                Console.WriteLine(com.ToString());
                sum += com.Imposto();
            }

            Console.WriteLine("IMPOSTO TOTAL: $ " + sum);




        }
    }
}
