using System;
using System.Globalization;

namespace Dev03 {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine("De quantas pessoas você quer saber a média de altura?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++) {
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++) {
            //    sum += vect[i];
            //}
            //double avg = sum / n;
            //Console.WriteLine("Altura média = " + avg.ToString("F2", CultureInfo.InvariantCulture));

           int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"Price average = {avg:F2}");
        }
    }
}