using System;
using ShapeDrawer;
using SplashKitSDK;

namespace DrawingShape
{
    public class Program
    {
        public static void Main()
        {

            Shape myShape = new Shape();

            new Window("Drawing Shape", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
             
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = (float)SplashKit.MouseX();
                    myShape.Y = (float)SplashKit.MouseY();
                }

                if (myShape.IsAt(SplashKit.MousePosition()))
                {
                    if (SplashKit.KeyDown(KeyCode.SpaceKey))
                    {
                        if(myShape.Color.Equals(Color.Blue))
                             myShape.Color = Color.Green;
                        else myShape.Color = Color.Blue;
                    }
                }

                myShape.Draw();

                SplashKit.RefreshScreen();

            }
            while (!SplashKit.WindowCloseRequested("Drawing Shape"));
        }
    }

}