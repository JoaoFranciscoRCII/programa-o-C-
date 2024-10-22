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
            int baSe, altura, conta;

            Console.WriteLine("Insira a base:");
            baSe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInsira a Altura:");
            altura = Convert.ToInt32(Console.ReadLine());

            conta = (baSe * altura) / 2;

            Console.WriteLine("\nO resultado e: {0} ", conta, baSe, altura);

            Console.ReadKey();

        }
    }
}
