using System;

namespace exec_seq_prop_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());

            sum = firstNumber + secondNumber;
            Console.WriteLine($"SOMA = {sum}");
        }
    }
}
