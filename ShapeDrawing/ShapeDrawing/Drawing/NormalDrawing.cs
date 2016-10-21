using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class NormalDrawing : IDrawing
{
    private Graphics canvas;
    private Pen pen;
    
    public NormalDrawing(Graphics canvas)
    {
        this.canvas = canvas;
    }
    public void DrawCircle(int x, int y, int size, Color color)
    {
        pen = new Pen(color);
        canvas.DrawEllipse(pen, x-size, y-size, size*2, size*2);
    }

    public void DrawPolyLine(Point[] points, Color color)
    {
        pen = new Pen(color);
        for (int i = 1; i < points.Length; i++)
            canvas.DrawLine(pen, points[i - 1], points[i]);
    }
}
