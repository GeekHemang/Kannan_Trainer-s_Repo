using OcpRefactoredApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpRefactoredApp.HDFC
{
    class HdfcDiwaliRatePolicy : IRatePolicy
    {
        public double CalcuateRate()
        {
            return 0.09;
        }
    }
}
