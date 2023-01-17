using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }

        public MyCircle() : this(Color.Blue, 50) { }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
            
        public override void Draw()
        {
            if (Selected)
            {                
                DrawOutline();
            }
            SplashKit.FillCircle(COLOR, X, Y, _radius);
        }
        public override void DrawOutline()
        {           
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }


        public override bool IsAt(Point2D pt)
        {
            Point2D pt2 = new Point2D();
            pt2.X = X;
            pt2.Y = Y;
            Circle circle = SplashKit.CircleAt(pt2, _radius);
            return SplashKit.PointInCircle(pt, circle);
        }
        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(Radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            Radius = reader.ReadInteger();
        }


    }
}
