using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drawing_Class_Task
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer Task 3.3", 800, 600);
            Drawing myDraw = new Drawing();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myDraw.Draw();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();

                    Point2D mouseposition = SplashKit.MousePosition();
                    myShape.X = (float)SplashKit.MouseX();
                    myShape.Y = (float)SplashKit.MouseY();
                    myDraw.AddShape(myShape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDraw.background = SplashKit.RandomRGBColor(225);
                }

                if (SplashKit.KeyDown(KeyCode.DeleteKey)||SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    foreach (Shape shape in myDraw.SelectedShapes)
                    {
                        myDraw.RemoveShape(shape);
                    }
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    Point2D selected = SplashKit.MousePosition();
                    myDraw.SelectShapesAt(selected);
                }

                SplashKit.RefreshScreen();
                

            } while (!SplashKit.WindowCloseRequested(window));
        }
    }
}
