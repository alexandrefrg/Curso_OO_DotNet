using System;

namespace exec_fix_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int qtdeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] arrInput = Console.ReadLine().Split(' ');

            string sobrenome = arrInput[0];
            int idade = int.Parse(arrInput[1]);
            double altura = double.Parse(arrInput[2]);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdeQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
