// See https://aka.ms/new-console-template for more information
using System;
using AljabarLibraries;

namespace AljabarLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // fungsi mencari akar kuadrat
            Console.WriteLine("Test Fungsi Akar Kuadrat");
            double[] akarKuadrat = Kuadrat.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Eqt\t: x^2 - 3x - 10 = 0");
            Console.WriteLine("Output\t: {" + akarKuadrat[0] + ", " + akarKuadrat[1] + "}");

            // fungsi mencari hasil kuadrat
            Console.WriteLine("\nTest Fungsi Hasil Kuadrat");
            double[] hasilKuadrat = Kuadrat.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Eqt\t: 2x - 3");
            Console.WriteLine("Output\t: {" + hasilKuadrat[0] + ", " + hasilKuadrat[1] + ", " + hasilKuadrat[2] + "}");
        }
    }
}