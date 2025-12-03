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
        }
    }
}