using Exercicios01;
using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Funcionarios p1, p2;


            p1 = new Funcionarios();
            p2 = new Funcionarios();
            
                //primeiro funcionario
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
                p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = int.Parse(Console.ReadLine());

                //segundo funcionario
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
                p2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
                p2.Salario = int.Parse(Console.ReadLine());

                //salario medio
            int sm = (p1.Salario + p2.Salario) / 2;
            Console.Write("Salario Medio: " + sm);

                            Console.ReadLine();

        }
    }
}
