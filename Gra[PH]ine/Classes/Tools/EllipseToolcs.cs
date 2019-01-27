﻿using Gra_PH_ine.Classes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gra_PH_ine.Classes.Tools
{
    class EllipseTool : Tool
    {
        public override void MouseDown(Point p)
        {
            NotArtist.Figures.Add(new Ellipse(p));
        }

        public override void MouseMove(Point p)
        {
           NotArtist.Figures[NotArtist.Figures.Count - 1].AddPoint(p);
        }
    }
}
