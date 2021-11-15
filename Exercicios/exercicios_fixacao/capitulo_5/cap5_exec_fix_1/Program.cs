using System;

namespace cap5_exec_fix_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaBancaria account;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Havera depósito inicial(s/n)? ");
            string hasInitialDeposit = Console.ReadLine().ToLower();

            while(hasInitialDeposit != "s" && hasInitialDeposit != "n")
            {
                Console.WriteLine("Digite apenas s ou n!");
                Console.Write("Havera depósito inicial(s/n)? ");
                hasInitialDeposit = Console.ReadLine().ToLower();
            }

            if(hasInitialDeposit == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine());

                account = new ContaBancaria(accountNumber, accountHolder, initialDeposit);
            }
            else
            {
                account = new ContaBancaria(accountNumber, accountHolder);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double depositValue = double.Parse(Console.ReadLine());
            account.Deposit(depositValue);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double withdrawValue = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawValue);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}
