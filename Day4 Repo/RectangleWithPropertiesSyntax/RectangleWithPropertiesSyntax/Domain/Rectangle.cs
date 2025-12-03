using System.Drawing;

namespace RectangleWithPropertiesSyntax.Domain
{
    class Rectangle
    {

        private int _width;
        private int _height;
        private string _color;
        private const int _upperBound = 100;
        private const int _lowerBound = 1;





        private int SanitizeDimension(int dimension)
        {


            if (dimension < _lowerBound)
                return 1;

            if (dimension > _upperBound)//Magic number
                return 100;

            return dimension;

        }



        public string MyInfo {
            get {
                return "This is Emerson Develoerp1";
            }
        }

        public int Width
        {
            get { return _width; }
            set { _width = SanitizeDimension(value); }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                
                _height = SanitizeDimension(value);
            }
        }


        public string Color
        {
            set
            {

                if (value == "red" || 
                    value == "blue" ||
                    value == "green")
                    _color = value;
                else

                    _color = "green";
            }
            get { return _color; }
        }


        public int Area
        {
            get { 
             return _width * _height;
            }
        }

        public int CalculateArea()
        {

            return _width * _height;
        }

    }
}
