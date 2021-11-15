using System;

namespace cap4_exec_fix_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double imposto = double.Parse(Console.ReadLine());
            func.AumentarSalario(imposto);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
