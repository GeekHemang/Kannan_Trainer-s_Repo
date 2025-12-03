using ManBoyInheritanceApp.Domain;
using System;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            //  CaseStudy2();

            //CaseStudy3();

            ///CaseStudy4();

            CaseStudy5();
        
        }

        private static void CaseStudy5()
        {
            object x;// ISA type of Object
            x = 100;

            Console.WriteLine(x.GetType());
            x = "hello";

            Console.WriteLine(x.GetType());

            x = new Man();
            Console.WriteLine(x.GetType());


            //Man temp = x as Man;
            //temp.Play();

            x = new Toddler();
            Console.WriteLine(x.GetType());
          

        }

        private static void CaseStudy4()
        {
            Man man= new Man();
            AtThePark(man);

            Infant infant= new Infant();
            AtThePark(infant);

            AtThePark(new Toddler());
            AtThePark(new Boy());

        }

         static void AtThePark(Man x)//Polymorphic method (ISA)
        
        {
            Console.WriteLine("At the park..");
            x.Play();
        
        }

        private static void CaseStudy3()
        {
            Man x; // IS a man or subclasses of man
            x = new Boy();

            x.Play();
            x.Read();

            //Boy temp = x as Boy;
            //temp.Eat();
           


        }

        private static void CaseStudy2()
        {
            Boy y;//(ISA) y expects boy object

            y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
           


        }

        private static void CaseStudy1()
        {
            Man x;// (ISA) x expects a Man object
            x = new Man();
            x.Play();
            x.Read();
        }
    }
}
