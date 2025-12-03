using ConstructorInheritanceApp.Domain.CasStudy2;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // new ChildOne();

            ChildTwo child1 = new ChildTwo();
            Console.WriteLine(child1.Age);

            ChildTwo child2 = new ChildTwo();
            Console.WriteLine(child2.Age);

            ChildTwo child3 = new ChildTwo(40);
            Console.WriteLine(child3.Age);


        }
    }
}
