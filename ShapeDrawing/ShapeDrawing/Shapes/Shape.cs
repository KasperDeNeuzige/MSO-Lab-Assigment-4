using System;
using System.Drawing;

public abstract class Shape
{
    public IDrawing d;
    public Color color;

	public Shape()
	{
	}

    public abstract void Draw();
	
}