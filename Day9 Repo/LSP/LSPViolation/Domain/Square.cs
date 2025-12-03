using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation.Domain
{
    class Square : Rectangle
    {

        public Square(int side):base(side,side)
        { 
        
        }

        public override void SetWidth(int side)
        {
           _width=_height= side;
        }
        public override void SetHeight(int side)
        {
            _width=_height= side;
        }
    }
}
