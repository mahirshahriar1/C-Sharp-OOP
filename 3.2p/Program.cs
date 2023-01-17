using System;
using System.Collections.Specialized;
using project;
using SplashKitSDK;

namespace project
{
    public class Program
    {
        public static void Main()
        {

            Drawing back = new Drawing();

            new Window("Drawing Shape", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    int x_pos = (int)SplashKit.MouseX();
                    int y_pos = (int)SplashKit.MouseY();
                    
                    back.AddShape(new Shape(x_pos, y_pos));
                    Console.WriteLine("left "+x_pos);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    back.SelectedShapeAt(SplashKit.MousePosition());                   
                }


                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    back.RemoveShape();
                    //back.deleteAll();                   
                }


                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {

                    back.Background = SplashKit.RandomRGBColor(255);                  
                }

                back.Draw();

                SplashKit.RefreshScreen();

            }
            while (!SplashKit.WindowCloseRequested("Drawing Shape"));
        }
    }

}

