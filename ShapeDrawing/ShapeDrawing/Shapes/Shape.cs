using System;
using System.Drawing;

public abstract class Shape
{
    protected int x, y;

	public Shape(int x, int y)
	{
        this.x = x;
        this.y = y;
	}

    public abstract void Draw(IDrawing d);
	
}