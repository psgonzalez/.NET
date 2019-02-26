using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("1 - Somar anos\n2 - Somar meses\n3 - Somar dias\n4 - Somar horas\n5 - Somar minutos\n6 - Somar segundos");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.WriteLine(somarAnos(data, num));
                    break;
                case 2:
                    Console.WriteLine(somarMeses(data, num));
                    break;
                case 3:
                    Console.WriteLine(somarDias(data, num));
                    break;
                case 4:
                    Console.WriteLine(somarHoras(data, num));
                    break;
                case 5:
                    Console.WriteLine(somarMinutos(data, num));
                    break;
                case 6:
                    Console.WriteLine(somarSegundos(data, num));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        static DateTime somarAnos(DateTime data, int anos)
        {
            return data.AddYears(anos);
        }

        static DateTime somarMeses(DateTime data, int meses)
        {
            return data.AddMonths(meses);
        }

        static DateTime somarDias(DateTime data, int dias)
        {
            return data.AddDays(dias);
        }

        static DateTime somarHoras(DateTime data, int horas)
        {
            return data.AddHours(horas);
        }

        static DateTime somarMinutos(DateTime data, int minutos)
        {
            return data.AddMinutes(minutos);
        }

        static DateTime somarSegundos(DateTime data, int segundos)
        {
            return data.AddSeconds(segundos);
        }
    }
}
