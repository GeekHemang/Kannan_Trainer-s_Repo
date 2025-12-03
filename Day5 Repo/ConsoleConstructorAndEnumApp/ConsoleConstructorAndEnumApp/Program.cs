using System;
using ConsoleConstructorAndEnumApp.Domain;

namespace ConsoleConstructorAndEnumApp
{
     class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect1 = new Rectangle(1, 2, "red",BorderStyleOptions.Double);
            PrintInfo(rect1);

           
           
        }

        static void CaseStudy1() {
            Rectangle rectangle1 = new Rectangle(10, 20, "yellow");
            PrintInfo(rectangle1);

            rectangle1.Color = "red";
            PrintInfo(rectangle1);
        }

        static void PrintInfo(Rectangle rect) {
            Console.WriteLine($"Width is {rect.Width}");
            Console.WriteLine($"Hieght is {rect.Height}");
            Console.WriteLine($"Color is {rect.Color}");
            Console.WriteLine($"border style  {rect.BorderStyle}");

        }
    }
}
