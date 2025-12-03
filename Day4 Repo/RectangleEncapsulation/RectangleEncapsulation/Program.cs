using RectangleEncapsulation.Domain;
using System;

class Program
{

    static void Main(string[] args)
    {
       
        Rectangle rect1 = new Rectangle();
        rect1.SetColor("red");
        rect1.SetHeight(5000);
        

        PrintInfo(rect1);

    }



    static void PrintInfo(Rectangle rect)
    {
        Console.WriteLine("color is " + rect.GetColor());
        Console.WriteLine("height is "+rect.GetHeight());

    }

}