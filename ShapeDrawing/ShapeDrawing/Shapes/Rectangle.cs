using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;
    private Color color = Color.Black;
    private Point[] points;

    public Rectangle(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;

    }
    
	public override void Draw(IDrawing d)
    {
        points = new Point[5];
        points[0] = new Point(x, y);
        points[1] = new Point(x + width, y);
        points[2] = new Point(x + width, y + height);
        points[3] = new Point(x, y + height);
        points[4] = new Point(x, y);

        d.DrawPolyLine(points, color);
    }
}

