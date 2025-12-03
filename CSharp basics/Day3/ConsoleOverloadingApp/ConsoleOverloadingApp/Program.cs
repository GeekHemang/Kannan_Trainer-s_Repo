using System;


class Program
{
    static void Main()
    {
        PrintInfo("hello  Emerson");
       // PrintInfo();
        PrintInfo(100);
        PrintInfo();
        PrintInfo(10.55f);
        PrintInfo();
        PrintInfo(10.44);
        PrintInfo();
        PrintInfo(10.33m);
        //PrintInfo(true)


    }

    static void PrintInfo(string input)
    {
        Console.WriteLine("overload  #1");
        Console.WriteLine($"string  input passed is {input} ");
       // Console.WriteLine($"string size is  {sizeof(String) ");
    }
    static void PrintInfo(int input)
    {
        Console.WriteLine("overlaod #2");
        Console.WriteLine($"int input passed is {input} ");
        Console.WriteLine($"size of integer {sizeof(int)} ");
       

    }

    static void PrintInfo(float input)
    {
        Console.WriteLine("overlaod #3");
        Console.WriteLine($"float input passed is {input} ");
        Console.WriteLine($"size of float {sizeof(float)} ");

    }
    static void PrintInfo(double input)
    {
        Console.WriteLine("overlaod #4");
        Console.WriteLine($"double input passed is {input} ");
        Console.WriteLine($"size of double {sizeof(double)} ");

    }

    static void PrintInfo(decimal input)
    {
        Console.WriteLine("overlaod #5");
        Console.WriteLine($"double input passed is {input} ");
        Console.WriteLine($"size of decimal {sizeof(decimal)} ");

    }

    static void PrintInfo() {
        Console.WriteLine("=======================================");
    }
}

