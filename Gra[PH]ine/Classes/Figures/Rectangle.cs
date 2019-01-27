﻿using Gra_PH_ine.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Gra_PH_ine.Classes.Figures
{
    class Rectangle:Figure
    {
        public Rectangle()
        {

        }
        public Rectangle(Point p) : base(p)
        {

        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
        public override void Draw(DrawingContext kt)
        {
            kt.DrawRectangle(new SolidColorBrush(Colors.Transparent),new Pen(Brushes.Black, 4),new Rect (points[0],points[1]));
        }
    }
}