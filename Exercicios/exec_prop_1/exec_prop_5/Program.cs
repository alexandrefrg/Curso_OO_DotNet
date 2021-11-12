using System;

namespace exec_prop_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] input;
            int cod_prod1, cod_prod2;
            int qty1, qty2;
            double price1, price2;

            input = Console.ReadLine().Split(' ');
            cod_prod1 = int.Parse(input[0]);
            qty1 = int.Parse(input[1]);
            price1 = double.Parse(input[2]);

            input = Console.ReadLine().Split(' ');
            cod_prod2 = int.Parse(input[0]);
            qty2 = int.Parse(input[1]);
            price2 = double.Parse(input[2]);

            string result = $"VALOR A PAGAR: R$ {(qty1 * price1) + (qty2 * price2):F2}";
            Console.WriteLine(result);
        }
    }
}
