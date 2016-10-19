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

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Draw()
    {
        d.DrawPolyLine(x        , y         , x + width, y         , color);
        d.DrawPolyLine(x + width, y         , x + width, y + height, color);
        d.DrawPolyLine(x + width, y + height, x        , y + height, color);
        d.DrawPolyLine(x        , y + height, x        , y        , color);
    }
}

