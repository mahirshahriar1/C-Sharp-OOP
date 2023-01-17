using SplashKitSDK;
namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;

        public Shape()
        {
            _color = Color.Green; 
            _x = _y = 0; 
            _width = _height = 100; 
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
            SplashKit.FillRectangle(_color, _x, _y,_width, _height);
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
    }
}