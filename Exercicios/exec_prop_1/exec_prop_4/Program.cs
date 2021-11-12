using System;

namespace exec_prop_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            int worked_hours;
            double hour_cost;

            number = int.Parse(Console.ReadLine());
            worked_hours = int.Parse(Console.ReadLine());
            hour_cost = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {worked_hours * hour_cost:F2}");
        }
    }
}
