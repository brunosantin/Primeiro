using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 100.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);


           /* Console.WriteLine("Entre oos dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a entrada de estoque : ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a Saida de estoque : ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados do Produto: " + p); */
        }
    }
} 