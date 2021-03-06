﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class SVGDrawing : IDrawing
{
    private StreamWriter writer;
    public SVGDrawing(StreamWriter writer)
    {
        this.writer = writer;
    }
    
    public void DrawCircle(int x, int y, int size, Color color)
    {
        string circleString = "  <circle cx =\"" + x + "\" cy =\"" + y + "\" r =\"" + size + "\" stroke-width =\"1\"" + Environment.NewLine + 
            "    fill=\"none\" stroke=\"" + color.Name.ToLower() + "\" />";
        writer.WriteLine(circleString);
    }

    public void DrawPolyLine(Point[] points, Color color)
    {
        string polyLineString = "  <polyline points=\"";
        polyLineString += points[0].X + "," + points[0].Y;
        for (int i = 1; i < points.Length; i++)
            polyLineString += " " + points[i].X + "," + points[i].Y;
        polyLineString += "\"" + Environment.NewLine + "    style=\"fill:none;stroke:" + color.Name.ToLower() + ";stroke-width:1\" />"; 

        writer.WriteLine(polyLineString);
    }

    public void StartDocument()
    {
        writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?>" + Environment.NewLine + 
            "<!DOCTYPE svg PUBLIC \"-//W3C//DTD SVG 1.1//EN\"" + Environment.NewLine + 
            "\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\">" + Environment.NewLine + 
            "<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");
    }

    public void EndDocument()
    {
        writer.WriteLine("</svg>");
    }
}
