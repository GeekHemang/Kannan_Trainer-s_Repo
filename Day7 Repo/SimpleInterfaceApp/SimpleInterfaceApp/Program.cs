using SimpleInterfaceApp.DataAccess;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoDbOperations(new CustomerDb());
            DoDbOperations(new InvoiceDb());
            DoDbOperations(new OrderDb());

        }

        //polymorphic method
        static void DoDbOperations(ICrudable obj) {

            Console.WriteLine(obj.GetType());
            Console.WriteLine("Doing db operations");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
            Console.WriteLine();
        
        }

    }
}
