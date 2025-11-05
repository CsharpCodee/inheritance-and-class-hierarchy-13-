using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._1
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }
        public SavingsAccount(string accountNumber, string owner, decimal interestRate): base(accountNumber, owner)
        {
            InterestRate = interestRate;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Недостаточно средств.");
            }
        }
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
