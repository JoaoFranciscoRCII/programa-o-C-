using System;


namespace P_2_Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
         
            // Escrever o simbolo do euro
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço e {1}€", produto1, preco1);
            Console.WriteLine("{0}, cujo preço e {1}€", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero : {2}", idade, codigo, genero);
            Console.WriteLine("Medida com 8 casa decimais: {0:F8} ", medida);
            Console.WriteLine("arredondado(tres casas decimais): {0:F3}", medida);
            Console.WriteLine("SEPARADOR decimal invariant culture: {0:F3}", medida);
    
            
            Console.ReadKey();

        }
    }
}
