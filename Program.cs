using System;
using BankLibrary;

namespace MySuperBank

{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Salma", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(200, DateTime.Now, "Chair");
            account.MakeWithdrawal(7, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Snack");
            account.MakeWithdrawal(1, DateTime.Now, "snack2");
            account.MakeWithdrawal(300, DateTime.Now, "Glasses");
            account.MakeWithdrawal(5, DateTime.Now, "Coke");


            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
