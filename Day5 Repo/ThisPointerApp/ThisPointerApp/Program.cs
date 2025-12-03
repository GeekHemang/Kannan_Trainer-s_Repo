using ThisPointerApp.Domain;

namespace ThisPointerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player virat = new Player("Virat", 38);

            Console.WriteLine(virat.Name);
            Console.WriteLine(virat.Age);

            Console.WriteLine("vvirat hash"+virat.GetHashCode());

            Player sachin = new Player("Sachin", 55);
            Console.WriteLine("sachi hash" + sachin.GetHashCode());

            Player elder =virat.WhoIsElder(sachin);
            Console.WriteLine(elder.Name);

            Console.WriteLine("elders hashcode"+elder.GetHashCode());
        }
    }
}
