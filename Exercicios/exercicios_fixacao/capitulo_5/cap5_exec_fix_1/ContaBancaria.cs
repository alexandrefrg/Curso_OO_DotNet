namespace cap5_exec_fix_1
{
    public class ContaBancaria
    {
        private const double WITHDRAW_TAX = 5;

        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; private set; }

        public ContaBancaria(int accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            AccountBalance = 0.0;
        }

        public ContaBancaria(int accountNumber, string accountHolder, double accountBalance) : this(accountNumber, accountHolder)
        {
            AccountBalance = accountBalance;
        }

        public void Deposit(double depositValue)
        {
            AccountBalance += depositValue;
        }

        public void Withdraw(double withdrawValue)
        {
            AccountBalance -= withdrawValue + WITHDRAW_TAX;
        }

        public override string ToString()
        {
            return $"Conta {AccountNumber}, Titular: {AccountHolder}, Saldo: $ {AccountBalance:F2}";
        }
    }
}
