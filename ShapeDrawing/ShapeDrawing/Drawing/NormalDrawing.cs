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
    public void DrawCircle(float x, float y, float size, Color color)
    {
        pen = new Pen(color);
        canvas.DrawEllipse(pen, new RectangleF(new PointF(x - size / 2, y - size / 2), new SizeF(size, size)));
    }

    public void DrawPolyLine(float x1, float y1, float x2, float y2, Color color)
    {
        pen = new Pen(color);
        canvas.DrawLine(pen, x1, y1, x2, y2);
    }
}
