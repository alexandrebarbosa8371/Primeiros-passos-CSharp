using System;
using System.Globalization;

class Program {
	static void Main(string[] args) {
		Console.Write("Digite o produto: ");
		string nome = Console.ReadLine();
		Console.Write("Digite o preço: ");
		double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		Produto p = new Produto(nome, preco);

		Produto p2 = new Produto {
			Nome = "TV",
			Preco = 900.00,
			Quantidade = 5
		};

		Console.WriteLine("Dados do Produto: " + p);
		Console.WriteLine("Dados do Produto: " + p2);
	}
}