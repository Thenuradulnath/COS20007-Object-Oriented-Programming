using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProg
{
    public abstract class Shape
    {
        private SplashKitSDK.Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;
        private bool _selected;
        public Shape(SplashKitSDK.Color color)
        {
            _color = SplashKitSDK.Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }

        public SplashKitSDK.Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set { _selected = value; }
        }
        public  abstract void Draw();
        public abstract void DrawOutline();

        public abstract bool IsAt(Point2D pt);

    }
}