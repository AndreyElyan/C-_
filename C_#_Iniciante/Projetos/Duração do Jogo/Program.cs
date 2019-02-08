using System.Globalization;
using System;





namespace CursoLogica
{



    class Ex1
    {



        static void Main(string[] args)
        {
            int x, y;
            
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            
            if (x > y)
            {
                Console.WriteLine("O JOGO DUROU " + ((y + 24) - x) + " HORA(S)");
            }
            else if (x < y)
            {
                Console.WriteLine("O JOGO DUROU " + Math.Abs(x - y) + " HORA(S)");
            }
            else if (x == y)
            {
                Console.WriteLine("O JOGO DUROU " + "24" + " HORA(S)");
            }

        }
    }
}