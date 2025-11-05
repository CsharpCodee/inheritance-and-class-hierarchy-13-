using System;

namespace Practic12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts = new BankAccount[3];

            accounts[0] = new CreditAccount("123456", "Alice", 1000, DateTime.Now.AddMonths(1));
            accounts[1] = new CheckingAccount("654321", "Bob", 500);
            accounts[2] = new SavingsAccount("789012", "Charlie", 0.03m);
            foreach (var account in accounts)
            {
                Console.WriteLine($"Счет владельца: {account.GetOwnerInfo()}, Номер счета: {account.GetAccountNumber()}, Баланс: {account.CheckBalance()}");

                account.Deposit(200);
                Console.WriteLine($"Баланс после пополнения на 200: {account.CheckBalance()}");
                try
                {
                    account.Withdraw(150);
                    Console.WriteLine($"Баланс после снятия 150: {account.CheckBalance()}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (account is CreditAccount creditAccount)
                {
                    Console.WriteLine($"Минимальный платеж по кредиту: {creditAccount.CalculateMinimumPayment()}");
                }
                else if (account is SavingsAccount savingsAccount)
                {
                    Console.WriteLine($"Начисленный процент: {savingsAccount.CalculateInterest()}");
                }

                Console.WriteLine();
            }
        }
    }

}
