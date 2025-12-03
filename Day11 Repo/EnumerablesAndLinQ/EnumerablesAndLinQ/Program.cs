



using System;
using System.Collections.Generic;
using AccountPublisherLIb.Domain;
using EnumerablesAndLinQ.ExtensionMethods;

using System.Linq;
using System.Runtime.CompilerServices;

//CaseStudy1();

CaseStudy3();

void CaseStudy3()
{

    IEnumerable<string> names;
    names = new string[3] { "HemangEmerson", "Kannan", "PreetiEmersonNoida" };
       
    //Deferred Execution
   var orderedNamesQuery  =names.OrderByDescending(n=>n.Length);

    //immediate execution
    var list = orderedNamesQuery.ToList();

    list.ForEach(n => Console.WriteLine(n));


}


//CaseStudy2();

void CaseStudy2()
{
    Console.WriteLine("Pravin".HelloEmerson());

    var acc1 = new Account(101, "Hemang");
    acc1.PrintDetails();
}

void CaseStudy1()
{
    IEnumerable<string> names;

  


    names = new string[3] { "Hemang","Kannan","Preeti" };

    foreach (string item in names) {

        Console.WriteLine(item);
    }

    // 
    Console.WriteLine("using enumerator");
    IEnumerator<string> cursor= names.GetEnumerator();
    while (cursor.MoveNext())
    {
        Console.WriteLine(cursor.Current.ToUpper());
    }
   

}