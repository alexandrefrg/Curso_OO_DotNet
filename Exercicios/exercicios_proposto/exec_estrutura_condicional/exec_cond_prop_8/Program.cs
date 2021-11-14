using System;

namespace exec_cond_prop_8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());

            double tax;
            if (salary <= 2000.0)
                tax = 0.0;
            else if (salary <= 3000.0)
                tax = (salary - 2000.0) * 0.08;
            else if (salary <= 4500.0)
                tax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            else
                tax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            if(tax == 0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine($"R$ {tax:F2}");
        }
    }
}
