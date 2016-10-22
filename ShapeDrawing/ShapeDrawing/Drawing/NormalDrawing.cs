using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class NormalDrawing : IDrawing
{
    private Graphics canvas;
    
    public NormalDrawing(Graphics canvas)
    {
        this.canvas = canvas;
    }

    public void DrawCircle(int x, int y, int size, Color color)
    {
        Pen pen = new Pen(color);
        // Note that we set the x and y off by the radius, this makes the drawing in line with the SVG drawing (and the example in the pdf)
        canvas.DrawEllipse(pen, x-size, y-size, size*2, size*2);
    }

    public void DrawPolyLine(Point[] points, Color color)
    {
        Pen pen = new Pen(color);
        for (int i = 1; i < points.Length; i++)
            canvas.DrawLine(pen, points[i - 1], points[i]);
    }
}
