using System;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tt = 3.14159;
            double raio, resultado;

            raio = double.Parse(Console.ReadLine());
            resultado = tt * raio * raio;
            Console.WriteLine("A : " + resultado);






            
        }
    }
}
