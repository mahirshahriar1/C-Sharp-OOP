using SplashKitSDK;
using System.Reflection.Metadata;

namespace project
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;

        private bool _selected;


        public Shape() : this(Color.Yellow)
        {
            
        }
        public Shape(Color color)
        {
            _color = color;                      
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

        public Color COLOR
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

        public virtual void SaveTo(StreamWriter writer)
        {
            writer.WriteColor(_color);
            writer.WriteLine(X);
            writer.WriteLine(Y);
        }
        public virtual void LoadFrom(StreamReader reader)
        {
            COLOR = reader.ReadColor();
            X = reader.ReadInteger();
            Y = reader.ReadInteger();
        }
        public abstract void Draw();
    
        public abstract bool IsAt(Point2D p);

        public abstract void DrawOutline();
          

    }
}