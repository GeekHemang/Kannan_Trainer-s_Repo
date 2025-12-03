using AccountPolyMorphsimApp.Domain;

namespace AccountPolyMorphsimApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount sa = new SavingsAccount(101, "Hemang", 1000);
            CurrentAccount ca = new CurrentAccount(102, "Ashish", 2000);

            PrintBalanceSheet(sa);
            PrintBalanceSheet(ca);


        }

      static   void PrintBalanceSheet(Account acc) {

            Console.WriteLine("accno is "+acc.Accno);
            Console.WriteLine("Name is " + acc.Name);
            Console.WriteLine("Balance is " + acc.Balance);
        }


    }
}
