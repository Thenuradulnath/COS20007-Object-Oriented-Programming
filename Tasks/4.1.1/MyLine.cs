using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;

        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            X = startX;
            Y = startY;
            EndX = endX;
            EndY = endY;
        }

        public MyLine() : this(Color.Blue, 0.0f, 0.0f, 60.0f, 0.0f)
        {
        }

        public float EndX
        {
            get { return _endX; }
            set { _endX = value; }
        }

        public float EndY
        {
            get { return _endY; }
            set { _endY = value; }
        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();

            SplashKit.DrawLine(Color, X, Y, X + EndX, Y + EndY);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 3);
            SplashKit.FillCircle(Color.Black, X + EndX, Y + EndY, 3);
        }

        public override bool IsAt(Point2D pt)
        {
            return (pt.X >= X) && (pt.X <= (X + EndX)) &&
                (pt.Y >= Y) && (pt.Y <= (Y + EndY));
        }
    }
}

