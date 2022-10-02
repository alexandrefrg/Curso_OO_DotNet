using System;

namespace cap6_exec_fix_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdeAlugueis = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeAlugueis; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                String nome = Console.ReadLine();

                Console.Write("Email: ");
                String email = Console.ReadLine();

                Console.Write("Quarto: ");
                int nroQuarto = int.Parse(Console.ReadLine());

                vect[nroQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine($"{i}: {vect[i]}");
            }
        }
    }
}

