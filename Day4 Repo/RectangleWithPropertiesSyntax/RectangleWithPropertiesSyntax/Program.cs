
using RectangleWithPropertiesSyntax.Domain;

class Program
{

    static void Main(string[] args) {

        Rectangle rect1 = new Rectangle();
        rect1.Color = "pink";
        rect1.Width = 101;
        rect1.Height = -50;
        Console.WriteLine(rect1.Color);
        Console.WriteLine(rect1.Height);
        Console.WriteLine(rect1.Width);
        //rect1.MyInfo = "Deveoper is Ashish";
       // args.Length = 0;
    
    }

}