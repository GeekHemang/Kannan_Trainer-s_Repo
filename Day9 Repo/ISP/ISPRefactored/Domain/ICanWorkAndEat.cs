using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactored.Domain
{
    //multiple inheritance of interfaces
    interface ICanWorkAndEat : ICanDoWork,ICanDoEat
    {
    }
}
