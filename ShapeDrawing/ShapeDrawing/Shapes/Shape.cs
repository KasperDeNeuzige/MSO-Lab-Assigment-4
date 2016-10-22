using System;
using System.Drawing;

public abstract class Shape
{
    protected int x, y, width, height;
    protected Color c;

	public Shape(int x, int y, int width, int height, Color c)
	{
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.c = c;
	}

    public abstract void Draw(IDrawing d);
	
}