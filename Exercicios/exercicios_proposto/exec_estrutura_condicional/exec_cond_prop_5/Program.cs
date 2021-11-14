using System;

namespace exec_cond_prop_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int item_code = int.Parse(input[0]);
            int item_quantity = int.Parse(input[1]);

            double item_cost;

            if (item_code == 1)
            {
                item_cost = 4.0;
            }
            else if (item_code == 2)
            {
                item_cost = 4.5;
            }
            else if (item_code == 3)
            {
                item_cost = 5.0;
            }
            else if (item_code == 4)
            {
                item_cost = 2.0;
            }
            else
            {
                item_cost = 1.5;
            }

            Console.WriteLine($"Total : R${item_cost * item_quantity:F2}");
        }
    }
}
