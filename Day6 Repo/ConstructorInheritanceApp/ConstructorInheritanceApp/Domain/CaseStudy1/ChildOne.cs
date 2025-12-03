using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Domain.CaseStudy1
{
     class ChildOne : ParentOne
    {
        public ChildOne() :base (){
            Console.WriteLine("Child Created");
        }
    }
}
