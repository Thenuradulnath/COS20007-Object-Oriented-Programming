using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace DrawingProg
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
            Window window = new Window("Shape Drawer Task 4.1",800,600);
            Drawing myDraw = new Drawing();
           ShapeKind kindToAdd= ShapeKind.Rectangle;

            do
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDraw.background = SplashKit.RandomColor();
                }

                if (SplashKit.KeyTyped(KeyCode.RKey))
                    kindToAdd = ShapeKind.Rectangle;
                if (SplashKit.KeyTyped(KeyCode.CKey))
                    kindToAdd = ShapeKind.Circle;
                if (SplashKit.KeyTyped(KeyCode.LKey))
                    kindToAdd = ShapeKind.Line;


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape = new MyRectangle();

                    switch (kindToAdd)
                    {
                        case ShapeKind.Rectangle:
                            newShape = new MyRectangle();
                            break;

                        case ShapeKind.Circle:
                            newShape = new MyCircle();
                            break;


                        case ShapeKind.Line:
                            newShape = new MyLine();
                            break;
                    }

                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();


                    myDraw.AddShape(newShape);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    Point2D mousePos;
                    mousePos.X = SplashKit.MouseX();
                    mousePos.Y = SplashKit.MouseY();

                    myDraw.SelectShapesAt(mousePos);
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    var selectedShapes = myDraw.SelectedShapes;

                    foreach (var shape in selectedShapes)
                    {
                        myDraw.RemoveShape(shape);
                    }
                }


                myDraw.Draw();


                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
