using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

public interface IDrawing
{
    void DrawCircle(int x, int y, int size, Color color);
    void DrawPolyLine(Point[] points, Color color);
}
