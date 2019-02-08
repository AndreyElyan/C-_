using System;
using System.Globalization;
using Course;

namespace exercicios1
{
    class Funcionario
    {
        private static void Main()
        {
            CL_Funcionario func = new CL_Funcionario();

            Console.WriteLine("Nome: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine("Digite a porcentagem para aumentar o salario");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);




        }
    }
}
