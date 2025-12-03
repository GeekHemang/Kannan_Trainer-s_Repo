using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolution.Domain
{
    class Rectangle : IPolygon
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {

            _height = height;
            _width = width;
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }

        public virtual void SetHeight(int height)
        {
            _height = height;
        }

        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width; ;
        }

        public int CalculateArea()
        {
            return _width * _height;
        }

        public int CalcuateArea()
        {
           return _width* _height;
        }

        public int CalculatePermiter()
        {
            return 2 * (_width + _height);
        }
    }
}
