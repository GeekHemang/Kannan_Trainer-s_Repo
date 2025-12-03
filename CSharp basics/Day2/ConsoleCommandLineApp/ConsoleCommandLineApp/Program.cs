
using System;

class Program
{


    static void Main(string[] myParams)
    {

        foreach (string p in myParams)
        {
            Console.WriteLine(p);
        }

        //if (myParams.Length==2) {
        //    string userName=myParams[0];
        //    int ntimes = int.Parse(myParams[1]);
        //    PrintNameNTimes(userName, ntimes);
        //}

        PrintNameNTimes(myParams[0],int.Parse( myParams[1]));//parameter
        PrintNameNTimes("champ", 20);//hardcoded
        Console.WriteLine("end of main");

    }

    static void PrintNameNTimes(string name, int times)
    {
        for (int counter = 1; counter <=times; counter++)
        {
            Console.WriteLine(name.ToUpper() + ":"+ counter);
        }
    }

}