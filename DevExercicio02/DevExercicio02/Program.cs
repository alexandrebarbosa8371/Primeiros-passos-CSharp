using System.Numerics;

namespace DevExercicio02 {
    internal class Program {
        static void Main(string[] args) {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel : #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = Convert.ToInt32(Console.ReadLine());
                vect[room] = new Estudante(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
