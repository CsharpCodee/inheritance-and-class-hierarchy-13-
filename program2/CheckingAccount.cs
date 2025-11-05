using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._1
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }
        public CheckingAccount(string accountNumber, string owner, decimal overdraftLimit): base(accountNumber, owner)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Превышен лимит овердрафта");
            }
        }

        private decimal withdrawal;
        public decimal Withdrawal
        {
            get {return withdrawal;}
            set {
                if (value > 4 * Balance)
                { Console.WriteLine("Слишком большая сумма."); }
                else withdrawal = value;
            }
        }
        public void overdraft(decimal withdraft)
        {
            Balance -= withdraft;
            Console.WriteLine($"{Balance}");
        }
        
    }
}
