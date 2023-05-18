using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DrawingContext
{
    class TestDrawing:Control
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(50, 50), 40, 40);
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(50, 50), 30, 30);
            drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(50, 50), 15, 15);

            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(100,10,40,60));
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(120, 50, 40, 60));
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(140, 90, 40, 60));
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(160, 130, 40, 60));

            base.OnRender(drawingContext);
        }
    }
}