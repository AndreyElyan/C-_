using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100)
            {
                conta = 50 + (minutos - 100) * 2.0;
            }
            Console.WriteLine("valor a pagar: R$: " + conta.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
