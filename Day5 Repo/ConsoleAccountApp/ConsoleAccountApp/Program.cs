using ConsoleAccountApp.Domain;
using System;

namespace ConsoleAccountApp
{
     class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(101, "kannan");
            PrintInfo(acc1);

            acc1.Deposit(1000);
            PrintInfo(acc1);

            acc1.Withdraw(2000);
            PrintInfo(acc1);
        }

        private static void PrintInfo(Account account)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"accno is {account.AccountNo}");
            Console.WriteLine($"Name is {account.Name}");
            Console.WriteLine($"Balance is {account.Balance}");
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}
