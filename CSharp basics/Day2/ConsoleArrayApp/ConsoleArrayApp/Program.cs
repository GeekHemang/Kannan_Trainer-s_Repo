

using System;

class Program {

    static void Main() {

        Console.WriteLine("welcome to array program");
        // CaseStudy1();
        // CaseStudy2();
        // CaseStudy3();
        CaseStudy4();
    }


    static void CaseStudy4()
    {
        string[] myNames = { "Gaurav","Krishna","Ashish","Hemang" };
        foreach (string name in myNames) {

          
            Console.WriteLine(name);
        
        }
    
    }

    static void CaseStudy3() {
        int[] ages = { 10, 20, 30, 40, 50, 60 };

        //for loop

        for ( int myIndex=0;myIndex<ages.Length/2; myIndex++) {

            ages[myIndex] = ages[myIndex]+1;
            Console.WriteLine(ages[myIndex]);
           
        }
        
    }
    static void CaseStudy2() {

        int[] ages = {10,20,30,40,50,60 };
        Console.WriteLine(ages.Length);
        Console.WriteLine(ages[0]);//hardcoded
        Console.WriteLine(ages[1]);
        Console.WriteLine(ages[2]);
        Console.WriteLine(ages[3]);
        Console.WriteLine(ages[4]); //Exceptions

    }
    static void CaseStudy1() {

        int age = 35;
        string name = "Sachin";
        Console.Write("Player name is " + name + "\n");
        Console.Write("plyaer age is ");
        Console.WriteLine(age);
        age = age + 10;
        //Console.WriteLine($"{age} , {name}");//dollar string
        Console.WriteLine("end of progam");

    }


}

