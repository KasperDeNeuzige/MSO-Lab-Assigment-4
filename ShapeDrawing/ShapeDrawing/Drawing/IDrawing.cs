using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

interface IDrawing
{
    void DrawCircle(float x, float y, float size, Color color);
    void DrawPolyLine(float x1, float y1, float x2, float y2, Color color);
}
