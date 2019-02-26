using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();

            if(frase.Length < 2)
                Console.WriteLine("String precisa ter tamanho maior que 1");
            else
            {
                frase = frase.Replace("a", "");
                frase = frase.Replace("e", "");
                frase = frase.Replace("i", "");
                frase = frase.Replace("o", "");
                frase = frase.Replace("u", "");

                frase = frase.Replace("A", "");
                frase = frase.Replace("E", "");
                frase = frase.Replace("I", "");
                frase = frase.Replace("O", "");
                frase = frase.Replace("U", "");

                Console.WriteLine(frase);
            }

            Console.ReadKey();
        }
    }
}
