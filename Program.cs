using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Salma", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(200, DateTime.Now, "Chair");
            account.MakeWithdrawal(300, DateTime.Now, "Glasses");
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
