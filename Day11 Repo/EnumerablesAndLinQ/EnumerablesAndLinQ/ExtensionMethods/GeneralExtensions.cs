using AccountPublisherLIb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerablesAndLinQ.ExtensionMethods
{
    static class GeneralExtensions
    {

        public static string HelloEmerson(this string inputName) {

            return $"Hello says Emerson to you {inputName}";
        }

        public static void PrintDetails(this Account inputAccount) {

            Console.WriteLine("accno is "+inputAccount.AccountNo);
            Console.WriteLine("name is " + inputAccount.Name);
            Console.WriteLine("Balance is " + inputAccount.Balance);
        }


    }
}
