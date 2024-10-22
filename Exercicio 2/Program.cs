using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = "Daniel oliveira";
            int quartos = 3;
            int idade = 21;
            double preco = 34.5;
            
            Console.WriteLine("\nNome Completo: {0}", nome);
            Console.WriteLine("\nQuantidade de quartos na sua casa: {0}", quartos);
            Console.WriteLine("\nIdade: {0}", idade);
            Console.WriteLine("\nPreco de um produto: {0}", preco);

            Console.WriteLine("\n{0}", nome);
            Console.WriteLine("{0}", quartos);
            Console.WriteLine("{0}", idade);
            Console.WriteLine("{0}", preco);


            Console.ReadKey();
        }
    }
}
