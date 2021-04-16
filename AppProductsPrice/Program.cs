using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppProductsPrice.Entities;

namespace AppProductsPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(); // Instanciando lista vazia.

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite o tipo do produto(c/u/i): ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Produto #" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Digite o valor da taxa: ");
                    double fee = double.Parse(Console.ReadLine()); // Polimorfismo / upcasting.
                    products.Add(new ImportedProduct(name, price, fee));  // Adicionando um objeto para lista
                }
                else if (ch == 'u')
                {
                    Console.Write("Digite a data de fabricação (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine()); // Polimorfismo / upcasting.

                    products.Add(new UsedProducts(name, price, date)); // Adicionando um objeto para lista
                }
                else
                {
                    products.Add(new Product(name, price)); // Adicionando um objeto para lista
                }

            }
            Console.WriteLine("\nEtiquetas de preço:");
            foreach(Product obj in products)
            {
                Console.WriteLine(obj.PriceTag()); // Imprimindo cada objeto da lista.
            }


            Console.ReadLine(); // Fim.
        }
    }
}
