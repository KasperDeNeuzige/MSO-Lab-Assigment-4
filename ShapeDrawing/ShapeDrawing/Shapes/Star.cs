using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Star : Shape
{

	//private int x;
	//private int y;
	private int width;
	private int height;
    private Color color = Color.Black;

	public Star (int x, int y, int width, int height) : base(x, y)
	{
		this.width = width;
		this.height = height;
        this.color = color;
	}

	public override void Draw (IDrawing d)
	{
        int numPoints = 5;
		Point[] pts = new Point[numPoints + 1];
		double rx = width / 2;
		double ry = height / 2;
		double cx = x + rx;
		double cy = y + ry;

		double theta = -Math.PI / 2;
		double dtheta = 4 * Math.PI / numPoints;
		int i;
		for (i = 0; i < numPoints + 1; i++) 
		{
			pts [i] = new Point (
				Convert.ToInt32(cx + rx * Math.Cos (theta)),
				Convert.ToInt32(cy + ry * Math.Sin (theta)));
			theta += dtheta;
		}
        d.DrawPolyLine(pts, color);
	}
}


