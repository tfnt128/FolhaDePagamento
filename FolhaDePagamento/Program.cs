using System.Globalization;
using System.Collections.Generic;
using System;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários? ");
            int n = int.Parse(Console.ReadLine());

            //Criando uma lista de funcionários
            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas Trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Funcionário terceirizado? (S/N): ");
                char tipo = char.Parse(Console.ReadLine());

                //adionando na lista a instanciação das propriedades de nome, horas trabalhadas e valor por hora
                if (tipo == 'S' || tipo == 's')
                {
                    list.Add(new Terceirizados(nome, horasTrabalhadas, valorPorHora));
                }
                else
                {
                    list.Add(new Funcionarios(nome, horasTrabalhadas, valorPorHora));
                }

                Console.WriteLine("---------------------------");


            }



            //foreach para imprimir cada segmento da lista
            foreach (Funcionarios func in list)
            {
                Console.WriteLine(func);
            }
        }
    }
}
