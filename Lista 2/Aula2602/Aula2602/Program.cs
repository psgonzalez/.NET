using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2602
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo = double.Parse(Console.ReadLine());

            angulo = (angulo * Math.PI) / 180;

            Console.WriteLine($"Seno: {Math.Sin(angulo)} \nCosseno: {Math.Cos(angulo)}");
        }
    }
}
