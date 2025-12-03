using SRPRefactored.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactored.Presentation
{
    class InvoiceConsolePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            string template = $"Id :{invoice.Id} " +
                $",description:{invoice.Description}" +
                $" cost is :{invoice.Cost}" +
                $" tax amt is :{invoice.CalcuateTax()}" +
                $" discount amt is {invoice. CalculateDiscount()}" +
                $" Final cost is :{invoice. FinalCost()}";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(template);
            Console.ResetColor();


        }

    }
}
