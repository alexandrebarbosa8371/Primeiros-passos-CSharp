using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace DevExercicio {
    class Program {
        static void Main(string[] args) {
          
            Console.Write("Digite a sua nota: ");

            double nota = Convert.ToDouble(Console.ReadLine());
            string resultado = nota switch
            {
                >= 9 and <= 10 => "Excelente!",
                >= 7 and < 9 => "Bom!",
                >= 6 and < 7 => "Regular",
                >= 0 and < 6 => "Ruim",
                _ => "Nota Inválida."
            };
            Console.WriteLine();
            Console.WriteLine(resultado);
            Console.WriteLine();

            object obj = "Texto";

            string tipo = obj switch
            {
                int i when i > 0 => $"Inteiro positivo: {i}",
                int i => $"Inteiro: {i}",
                string s => $"String: {s}",
                bool b => $"Booleano: {b}",
                null => "Nulo",
                _ => "Tipo desconhecido"
            };
            Console.WriteLine(tipo);
        }
    }
}