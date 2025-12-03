using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Domain
{
    class Manager : Employee
    {
        private double _hra;
        private double _ta;
        private double _da;
        public Manager(int id, string name, double basicSalary) 
            : base(id, name, basicSalary)
        {
            _hra = .50*_basicSalary;
            _ta= .40*_basicSalary;
            _da= .30*_basicSalary;
        }

        public override double CalculateTotalSalary()
        {
            return _basicSalary + _ta + _da+_hra;
        }
        public override string ToString()
        {
            return "Manager";
        }

        public override string Role {
            get {
                return "Manager ".ToUpper();
             }
        }
    }
}
