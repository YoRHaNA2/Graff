﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using Gra_PH_ine.Classes;

namespace Gra_PH_ine.Figures
{
    public class Line:Figure
    {
        
        public Line()
        {
           
        }
        public Line(Point p) : base(p)
        {
            Fill = NotArtist.SelectedFill.Clone();
            Line = NotArtist.SelectedLine.Clone();
        }
        public override void AddPoint(Point p)
        {
            points[1] = p;
        }
        public override void Draw (DrawingContext kt)
        {
            kt.DrawLine(Line, points[0], points[1]);
        }
    }
}
