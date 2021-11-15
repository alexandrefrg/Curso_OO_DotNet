using System;

namespace exec_while_prop_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum_alc = 0;
            int sum_gas = 0;
            int sum_die = 0;

            int input = int.Parse(Console.ReadLine());

            while(input != 4)
            {
                if (input == 1)
                    sum_alc++;
                else if (input == 2)
                    sum_gas++;
                else if (input == 3)
                    sum_die++;

                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {sum_alc}");
            Console.WriteLine($"Gasolina: {sum_gas}");
            Console.WriteLine($"Diesel: {sum_die}");
        }
    }
}
