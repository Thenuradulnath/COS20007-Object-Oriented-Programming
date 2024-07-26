using System;
using SplashKitSDK;

namespace Drawing
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("shape Drawer", 800, 600);
            Shape myShape = new Shape();
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
                        myShape.Color = Color.Red;
                    }
                    myShape.Draw();
                }
                SplashKit.RefreshScreen();

            } while (!SplashKit.WindowCloseRequested(window));
        }
    }
}
