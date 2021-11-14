using System;

namespace exec_while_prop_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int attempt_password = int.Parse(Console.ReadLine());

            while(attempt_password != 2002)
            {
                Console.WriteLine("Senha Invalida");
                attempt_password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
