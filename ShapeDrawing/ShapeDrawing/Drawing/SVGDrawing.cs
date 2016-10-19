using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class SVGDrawing : IDrawing
{
    private Graphics canvas;

    public SVGDrawing(Graphics canvas)
    {
        this.canvas = canvas;
    }

    public void DrawCircle(float x, float y, float size, Color color)
    {
        throw new NotImplementedException();
    }

    public void DrawPolyLine(float x1, float y1, float x2, float y2, Color color)
    {
        throw new NotImplementedException();
    }
}
