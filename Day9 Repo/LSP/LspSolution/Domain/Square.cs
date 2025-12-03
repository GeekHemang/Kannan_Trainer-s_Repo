using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.Domain
{
    class Square : IPolygon
    {

        private int _side;
        public Square(int side)
        { 
         _side = side;
        }

        public int CalcuateArea()
        {
            return _side * _side;
        }

        public int CalculatePermiter()
        {
            return 4 * _side;
        }

        public int GetSide() {
            return _side;
         }

        public void SetSide(int side)
        {

            _side = side;
        }

     
    }
}
