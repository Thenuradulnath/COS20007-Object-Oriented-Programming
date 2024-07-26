using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SplashKitSDK;

namespace DrawingProg
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(SplashKitSDK.Color color, int radius) : base(color)
        {
            Radius = radius;
        }

        public MyCircle() : this(SplashKitSDK.Color.Blue, 50)
        {
        }

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

            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(SplashKitSDK.Color.Black, X, Y, Radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            double distanceX = Math.Abs(pt.X - X);
            double distanceY = Math.Abs(pt.Y - Y);

            return (distanceX <= Radius) && (distanceY <= Radius);
        }

    }
}