using System;
using System.Globalization;

namespace ConsoleApp1043
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            String[] vet;

            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if  (a % b == 0) {
                Console.WriteLine("Sao Multiplos");
            }

            else    {
                Console.WriteLine("Nao sao Multiplos");
                    }
            Console.ReadLine();


            
            
        }
    }
}