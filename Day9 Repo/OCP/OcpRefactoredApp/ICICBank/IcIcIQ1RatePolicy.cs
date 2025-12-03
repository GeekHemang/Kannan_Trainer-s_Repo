using OcpRefactoredApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpRefactoredApp.ICICBank
{
    class IcIcIQ1RatePolicy : IRatePolicy
    {
        public double CalcuateRate()
        {
            return 0.10;
        }
    }
}
