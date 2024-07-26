using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private SplashKitSDK.Color _background;
        private SplashKitSDK.Color Color;

        public Drawing(SplashKitSDK.Color background)
        {
            _background = background;
            _shapes = new List<Shape>();
        }
        public SplashKitSDK.Color background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }
        public Drawing() : this(SplashKitSDK.Color.White)
        {

        }
        public List<Shape> SelectedShapes
        {
            get
            {
                var result = new List<Shape>(); ;
                foreach (var shape in _shapes)
                {
                    if (shape.Selected)
                    {
                        result.Add(shape);
                    }
                }
                return result;
            }
        }
        public int ShapeCount
        {
            get { return _shapes.Count(); }
        }
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }
        public void RemoveShape(Shape shape)
        {
            _shapes.Remove(shape);
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
            }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (var shape in _shapes)
            {
                if (shape.IsAt(pt))
                {
                    shape.Selected = true;
                }
                else { shape.Selected = false; }
            }
        }

    }
}

