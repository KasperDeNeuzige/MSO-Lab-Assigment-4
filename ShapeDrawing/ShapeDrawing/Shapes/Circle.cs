using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{
    private int size;
    private Color color = Color.Black;

    public Circle(int x, int y, int size) : base (x, y)
    {
        this.size = size;
    }

    public override void Draw(IDrawing d)
    {
        d.DrawCircle(x, y, size, color);
    }

}
