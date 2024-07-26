using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        private SplashKitSDK.Color _color;
        private float _x, _y;
        private int _width, _height;

        public Shape()
        {
            _color = SplashKitSDK.Color.Pink;
            _x = _y = 0;
            _width = _height = 100;
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

        public void Draw()
        {
            SplashKitSDK.SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public bool IsAt(Point2D pt)
        {
            return SplashKitSDK.SplashKit.PointInRectangle(pt, SplashKitSDK.SplashKit.RectangleFrom(X, Y, _width, _height));
        }
    }
}