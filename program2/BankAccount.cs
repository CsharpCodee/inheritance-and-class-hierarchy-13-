using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic12._1
{
    public abstract class BankAccount
    {
        public string Owner { get; private set; }
        public decimal Balance { get; protected set; }
        public string AccountNumber { get; private set; }
        protected BankAccount(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 0.0m;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public decimal CheckBalance()
        {
            return Balance;
        }
        public string GetOwnerInfo()
        {
            return Owner;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }
    }
}
