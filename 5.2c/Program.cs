using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using project;
using SplashKitSDK;

namespace project
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;

            Drawing back = new Drawing();

            int cnt = 0;
            float startx, starty, endx, endy;
            startx = starty = endx = endy = 0;
            bool ok = false;

            new Window("Drawing Shape", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
               
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                    //Console.WriteLine(1);
                }
                
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;                 
                }

                if (kindToAdd == ShapeKind.Line)
                {
                   
                    if (SplashKit.MouseClicked(MouseButton.LeftButton))
                    {
                        cnt++;
                        Shape newShape;
                       
                        if (cnt == 1)
                        {
                            startx = SplashKit.MouseX();
                            starty = SplashKit.MouseY();                          
                        }
                        if (cnt == 2)
                        {
                            endx = SplashKit.MouseX();
                            endy = SplashKit.MouseY();
                            cnt = 0;
                            ok = true;
                        }

                        if (ok)
                        {
                            newShape = new MyLine(Color.Green, startx, starty, endx, endy);
                            back.AddShape(newShape);
                            ok = false;
                        }
                    }
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle ShapeDrawn = new MyRectangle();
                        ShapeDrawn.X = SplashKit.MouseX();
                        ShapeDrawn.Y = SplashKit.MouseY();
                        back.AddShape(ShapeDrawn);
                    }
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle ShapeDrawn = new MyCircle();
                        ShapeDrawn.X = SplashKit.MouseX();
                        ShapeDrawn.Y = SplashKit.MouseY();
                        back.AddShape(ShapeDrawn);
                    }
                    

                    Console.WriteLine("Mouse Left");

                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    back.SelectedShapeAt(SplashKit.MousePosition());
                    Console.WriteLine("Mouse Right");
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

                if (SplashKit.KeyDown(KeyCode.SKey))
                {
                    back.Save("/Users/Mahir/Pictures/Shapes.txt");
                }

                if (SplashKit.KeyTyped(KeyCode.OKey))
                {
                    try
                    {
                        back.Load("/Users/Mahir/Pictures/Shapes.txt");
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine("Error loading file: {0}", e.Message);
                    }
                }

                back.Draw();

                SplashKit.RefreshScreen();

            }
            while (!SplashKit.WindowCloseRequested("Drawing Shape"));
        }
    }

}

