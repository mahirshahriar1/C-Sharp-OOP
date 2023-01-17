using SplashKitSDK;

namespace project
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;
        public Shape(int x,int y)
        {
            _color = Color.Green;
            _x = x;
            _y = y;
            /////////////////
            _width = _height = 100;
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }


        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }
        public bool IsAt(Point2D p)
        {
            //if ((point.X > _location.X && point.X < (_location.X + _width)) && (point.Y > _location.Y && point.Y < (_location.Y + _height)))
            //{
            //    return true;
            //}
            //return false;
            bool b = SplashKit.PointInRectangle(p, SplashKit.RectangleFrom(X, Y, _width, _height));
            return b;
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }

    }
}