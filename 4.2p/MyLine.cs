using System;
using SplashKitSDK;
using System.Collections.Generic;
using project;

namespace project
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;


        public MyLine(Color color, float startX, float startY, float endX, float endY)
        {
            _endX = endX;
            _endY = endY;
            X = startX;
            Y = startY;
        }

        public float endX
        {
            get
            {
                return _endX;
            }
        }

        public float endY
        {
            get
            {
                return _endY;
            }
        }
  
        public override void Draw()
        {            
            if (Selected)
                DrawOutline();
            //Console.WriteLine(X+" "+Y+" "+endX+" "+endY);
            SplashKit.DrawLine(Color.Green, X, Y, endX, endY);
        }

        
        public override void DrawOutline()
        {            
            Circle firstCircle = SplashKit.CircleAt(X, Y, 5);
            Circle secondCircle = SplashKit.CircleAt(endX, endY, 5);
            SplashKit.DrawCircle(Color.Black, firstCircle);
            SplashKit.DrawCircle(Color.Black, secondCircle);
        }

       
        public override bool IsAt(Point2D point)
        {
            return SplashKit.PointOnLine(point, SplashKit.LineFrom(X, Y, endX, endY));
        }
    }
}

