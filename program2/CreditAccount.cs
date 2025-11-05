using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._1
{
    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; private set; }
        public DateTime DueDate { get; private set; }

        public CreditAccount(string accountNumber, string owner, decimal creditLimit, DateTime dueDate): base(accountNumber, owner)
        {
            CreditLimit = creditLimit;
            DueDate = dueDate;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= CreditLimit)
            {
                Balance += amount;
            }
            else
            {
                throw new InvalidOperationException("Превышен кредитный лимит");
            }
        }
        public decimal CalculateMinimumPayment()
        {
            return Balance * 0.05m;
        }
    }
}
