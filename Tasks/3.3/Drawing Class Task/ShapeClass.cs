using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Class_Task
{
    public class Shape
    {
        private SplashKitSDK.Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;
        private bool _selected;
        public Shape()
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
        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            if (Selected) 
            { 
                DrawOutline();
            }
        }
        public bool IsAt(Point2D p)
        {
            return SplashKit.PointInRectangle(p, SplashKit.RectangleFrom(X, Y, _width, _height));
        }
        public void DrawOutline()
        {
            SplashKit.DrawRectangle(SplashKit.ColorBlack(), _x-2, _y -2, _width +4 , _height +4);
        }
    }
}