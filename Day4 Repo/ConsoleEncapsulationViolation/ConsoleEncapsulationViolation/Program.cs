using ConsoleEncapsulationViolation.Domain;
using System;

namespace ConsoleEncapsulationViolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////int[] scores = new int[3];
            //int[] scores =  {10,20,30 };
            //Console.WriteLine(scores);
            //foreach (int score in scores)
            //{
            //    Console.WriteLine(score);
            //}

            Rectangle[] manyRectangles = new Rectangle[3];

            //Console.WriteLine(manyRectangles);

           

            Rectangle r2 = new Rectangle();
            r2.width = 2;
            r2.height = 2;
            Console.WriteLine(r2.width);
            Rectangle temp = r2;
            temp.width = 20;
            Console.WriteLine(r2.width) ;
            Console.WriteLine(temp.width);
            Console.WriteLine(temp.GetHashCode());
            Console.WriteLine(r2.GetHashCode());


            Rectangle r3 = new Rectangle();
            r3.width = 3;
            r3.height = 3;

            manyRectangles[0] = new Rectangle();
            manyRectangles[0].width = 1;
            manyRectangles[0].height = 1;

            manyRectangles[1] = r2;
            manyRectangles[2] = r3;

            PrintInfo(manyRectangles);

            //Rectangle temp;//exects objects
            //temp = manyRectangles[2];


        }


        static void CaseSTudy1() {

            Rectangle big = new Rectangle();
            big.width = 1000;
            big.color = "xyjldfjldjfldfj";
            big.height = -100;
            //DRY--> Dont Repeat Yourself
            //PrintInfo(big,"big details");
            PrintInfo(big);





            Rectangle small = new Rectangle();
            small.width = 10;
            small.height = 50;
            small.color = "red";
            string currentColor = small.color;//read
            Console.WriteLine(small.color);
            PrintInfo(small);
            //PrintInfo(small,"small details");


            string info = GetDevInfo();
            Console.WriteLine(info);
            Console.WriteLine(GetDevInfo());

        }

        static void PrintInfo(Rectangle r) //expects an object
        {
          
            Console.WriteLine("Printing REctangle Info....");
            Console.WriteLine();
            Console.WriteLine( "width is "+r.width);
            Console.WriteLine("height is " + r.height);
            Console.WriteLine("color is "+r.color);
            Console.WriteLine( "Area is"+r.CalculateArea());
            Console.WriteLine("hascode is "+r.GetHashCode());
            Console.WriteLine();
        }
        static void PrintInfo(Rectangle[] rectangles) {
            foreach (Rectangle rect in rectangles)
            {
                PrintInfo(rect);
            }
        
        }

        //static void PrintInfo(Rectangle r, string details) {
        //    Console.WriteLine(details);
        //    PrintInfo(r);
        //}
        static string GetDevInfo() {
            return "Dev is Kannan @Emerson";
        }
    }
}
