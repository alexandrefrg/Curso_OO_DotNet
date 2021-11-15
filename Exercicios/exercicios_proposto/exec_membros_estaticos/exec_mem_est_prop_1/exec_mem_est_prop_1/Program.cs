using System;

namespace exec_mem_est_prop_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai compra? ");
            double quantia = double.Parse(Console.ReadLine());

            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.DolarPraReal(quantia, cotacao):F2}");
        }
    }
}
