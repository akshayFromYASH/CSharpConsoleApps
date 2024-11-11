using System.Linq.Expressions;
using System.Reflection.Emit;

namespace Threading
{
    public class BankAccount
    {
        private static readonly object _lockobject = new object();
        private static decimal _balance;
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        // Deposit money into the account
        public void Deposit(object amount)
        {
            lock (_lockobject)
            {
                Console.WriteLine($"Depositing {amount:C}");
                _balance += (decimal)amount;
                Console.WriteLine($"New Balance: {_balance:C}");
            }
        }

        // Withdraw money from the account
        public void Withdraw(object amount)
        {
            lock (_lockobject)
            {
                if (_balance >= (decimal)amount)
                {
                    Console.WriteLine($"Withdrawing {amount:C}");
                    _balance -= (decimal)amount;
                    // Console.WriteLine($"New balance: {_balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!");
                }
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}