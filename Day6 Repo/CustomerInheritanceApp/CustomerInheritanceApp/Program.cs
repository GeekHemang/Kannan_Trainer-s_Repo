using CustomerInheritanceApp.Domain;
using System;

namespace CustomerInheritanceApp
{
     class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer("C2001", "Hemang");
            Customer c2 = new Customer("C2001", "Hemangxyz");
            Customer c3 = c1;

            Console.WriteLine(c1==c2);//REference equlity
            //Console.WriteLine(c1==c3);

            Console.WriteLine(c1.Equals(c2));//Value based equality

        }

        private static void CaseStudy2()
        {
            Customer c1 = new Customer("C2001", "Hemang");

            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
        }

        static void CaseStudy1() {

            PrintInfo(new Customer("C2001", "Hemang"));
            PrintInfo(new Customer("C3001", "Preeti", "Delhi"));
        }
        static void PrintInfo(Customer customer)
        {
            Console.WriteLine("id :"+customer.Id);
            Console.WriteLine("name :"+customer.Name);
            Console.WriteLine("location :" + customer.Location);
        }
    }
}
