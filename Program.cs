using System.Globalization;

namespace SistemaDeEstoquePOOcomCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}