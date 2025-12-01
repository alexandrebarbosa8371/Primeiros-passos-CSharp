using System.Globalization;

namespace Dev02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Você irá fazer um depósito inicial? (s/n)");
            char respostaDeposito = char.Parse(Console.ReadLine().ToLower());

            double saldoInicial = 0;

            if (respostaDeposito == 's') {
                Console.Write("Informe um valor para o depósito inicial: ");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria conta = new ContaBancaria(numeroConta, nomeTitular, saldoInicial);
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}