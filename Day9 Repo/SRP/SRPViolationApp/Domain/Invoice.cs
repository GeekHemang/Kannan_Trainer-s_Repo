using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Domain
{
    class Invoice
    {

        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double TAX = .10;

        public Invoice(int id, string description, double cost, double disocunt)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = disocunt;

        }

        public double CalcuateTax() { 
          return _cost * TAX;
        }

        public double CalculateDiscount() {
            return _cost * _discountPercent;

        }

        public double FinalCost() {

            return (_cost - CalculateDiscount() ) + CalcuateTax();
        
        }

        public void PrintInvoice()
        {
            string template = $"Id :{_id} " +
                $",description:{_description}" +
                $" cost is :{_cost}" +
                $" tax amt is :{CalcuateTax()}" +
                $" discount amt is {CalculateDiscount()}" +
                $" Final cost is :{FinalCost()}";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(template);
            Console.ResetColor();


        }

    }
}
