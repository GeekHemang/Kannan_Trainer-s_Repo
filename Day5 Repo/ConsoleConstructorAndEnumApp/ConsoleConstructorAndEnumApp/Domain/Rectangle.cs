using System;

namespace ConsoleConstructorAndEnumApp.Domain
{
    class Rectangle
    {
        private string _color;

        private readonly int _width; //immutable
        private readonly int _height;
        private readonly BorderStyleOptions _borderStyle;

        private const int UPPER_BOUND = 100;
        private const int LOWER_BOUND = 1;


        public Rectangle(int width, int height, string color)
        {

            _width = SanitizeDimension(width);
            _height = SanitizeDimension(height);
            _color = SanitizeColor(color);


            Console.WriteLine("object created(#1)");

        }

        public Rectangle(int width, int height, string color,BorderStyleOptions borderStyle)
        {

            _width = SanitizeDimension(width);
            _height = SanitizeDimension(height);
            _color = SanitizeColor(color);
           
            _borderStyle = borderStyle;
            Console.WriteLine("object created(#2)");

        }

        public BorderStyleOptions BorderStyle
        {

            get { return _borderStyle; }
        }


        public int Width
        {
            get { return _width; }

        }

        public int Height
        {
            get
            {
                return _height;
            }

        }


        public string Color
        {

            get { return _color; }
            set
            {
                _color = SanitizeColor(value);
            }
        }


        public int Area
        {
            get
            {
                return _width * _height;
            }
        }

        private string SanitizeColor(string color)
        {

            if (color == "red" || color == "blue" || color == "green")
                return color;

            return "green";
        }

        private int SanitizeDimension(int dimension)
        {


            if (dimension < LOWER_BOUND)
                return LOWER_BOUND;

            if (dimension > UPPER_BOUND)//Magic number
                return UPPER_BOUND;

            return dimension;

        }



      


    }
}
