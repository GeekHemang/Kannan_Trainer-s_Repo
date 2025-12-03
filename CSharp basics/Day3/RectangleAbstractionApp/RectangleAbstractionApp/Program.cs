
using System;
using RectangleAbstractionApp.Domain;

namespace RectangleAbstractionApp
{
     class Program
    {
        static void Main()
        {
            Rectangle small;//small expects an object of rectnagle
            small = new Rectangle();

            small.width = 10;
            small.height = 20;
            small.color = "red";

            Console.WriteLine($"small width is {small.width}," +
                $"small height is {small.height},color is {small.color}");
            Console.WriteLine($"Area of small is {small.CalculateArea()}");

               
            
        }
    }
}
