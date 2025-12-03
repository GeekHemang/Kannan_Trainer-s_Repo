namespace RectangleEncapsulation.Domain
{
    class Rectangle
    {

        private int _width;
        private int _height;
        private string _color;
        private const int _upperBound = 100;
        private const int _lowerBound = 1;



        public void SetWidth(int width)
        {

           

            _width = SanitizeDimension( width);

        }

        private int SanitizeDimension(int dimension)
        {
           

            if (dimension < _lowerBound)
                return 1;

            if (dimension > _upperBound)//Magic number
                return 100;

            return dimension;

        }
        public int GetWidth()
        {
            return _width;
        }

        public void SetHeight(int height)
        {
           

            _height = SanitizeDimension( height);


        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetColor(string color)
        {
            if (color == "red" || color == "blue" || color == "green")
                _color = color;
            else
                _color = "green";

        }
        public string GetColor()
        {
            return _color;
        }


        public int CalculateArea()
        {

            return _width * _height;
        }

    }
}
