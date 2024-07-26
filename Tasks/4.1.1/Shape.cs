﻿using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    public abstract class Shape
    {
        private Color _color;
        private float _x;
        private float _y;

        private bool _selected;
        public Shape(Color color)
        {
            _color = Color.Green;
            _x = 0.0f;
            _y = 0.0f;
        }
        public Shape(): this(Color.Yellow) { }

        public Color Color
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
        public abstract void Draw();
        public abstract void DrawOutline();
        public abstract bool IsAt(Point2D pt);

    }
}