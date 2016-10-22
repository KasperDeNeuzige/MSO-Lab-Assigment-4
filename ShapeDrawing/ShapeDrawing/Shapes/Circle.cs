using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{
    private int size;
    private Color color = Color.Black;

    public Circle(int x, int y, int width, int height, Color c) : base(x, y, width, height, c)
    {
        size = width;
    }

    public override void Draw(IDrawing d)
    {
        d.DrawCircle(x, y, size, color);
    }

}
