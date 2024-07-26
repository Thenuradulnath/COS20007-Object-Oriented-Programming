using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SplashKitSDK;

namespace Drawing_Class_Task
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private SplashKitSDK.Color _background;
        internal SplashKitSDK.Color Color;

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
        public Drawing():this(SplashKitSDK.Color.White)
        {

        }
        public List<Shape> SelectedShapes
        {
            get
            {
                var result = new List<Shape>(); ;
                foreach (Shape shape in _shapes)
                {
                    if (shape.Selected)
                        {
                            result.Add(shape);
                        }
                }
                return result;
             }
        }
    public  int ShapeCount
        {
            get { return _shapes.Count; }
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
            foreach (Shape shape in _shapes)
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
