using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactored.Domain
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

            return _cost - CalculateDiscount()  + CalcuateTax();
        
        }

        public int Id { get { return _id; } }
        public string Description { get { return _description;
                } }
        public double Cost { get { return _cost; } }

        public static void Foo() {
            Console.WriteLine("Inside foo");
        }
      
    }
}
