using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double intervalos;

            intervalos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalos >= 0 && intervalos <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (intervalos >= 25 && intervalos <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalos >= 50 && intervalos <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (intervalos >= 75 && intervalos <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            else
            {
                Console.WriteLine("Fora de intervalo");
            }

                Console.ReadLine();

        }
    }
}
