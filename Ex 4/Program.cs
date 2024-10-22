using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baSe, altura, conta;

            Console.WriteLine("Insira a base:");
            baSe = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira a Altura:");
            altura = double.Parse(Console.ReadLine());

            conta = (baSe * altura) / 2;

            Console.WriteLine("\nO resultado e: {0} ", Math.Round(conta), baSe, altura);

            Console.ReadKey();

        }
    }
}
