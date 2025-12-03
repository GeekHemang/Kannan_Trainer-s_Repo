using EmployeePolymorphismApp.Domain;

namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var developer = new Developer(1001, "Hemang", 20000);
            var manager = new Manager(2001, "Ashish", 50000);

            PrintSalarySlip(developer);
            PrintSalarySlip(manager);

        }

       static void PrintSalarySlip(Employee employee)
        {
            //Console.WriteLine("job is :"+employee.GetType().Name);
            Console.WriteLine("toString Role :"+employee.ToString());
            Console.WriteLine("Role :" + employee.Role);
            Console.WriteLine("id " + employee.Id);
            Console.WriteLine("name " + employee.Name);
            Console.WriteLine("basic " + employee.BasicSalary);
            Console.WriteLine("Total salry " + employee.CalculateTotalSalary());
        }
    }
}
