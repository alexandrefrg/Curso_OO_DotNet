using System;

namespace prim_exec_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionario:");
            Funcionario f1 = new Funcionario();
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Funcionario f2 = new Funcionario();
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double average_salary = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {average_salary:F2}");
        }
    }
}
