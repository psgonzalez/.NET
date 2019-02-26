using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            int inicio = frase.IndexOf('b');
            int fim = frase.LastIndexOf('b');
            string sub = frase.Substring(inicio, fim);

            Console.WriteLine($"Começa no índice: {inicio}\nFoi encontrado a sequência: {sub}\nTamanho: {sub.Length}");
        }
    }
}
