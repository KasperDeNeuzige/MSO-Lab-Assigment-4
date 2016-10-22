using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

public class Parser
{
	public static List<Shape> ParseShapes(string Filename)
	{
		// Load xml documents
		XmlDocument doc = new XmlDocument();
		doc.Load(Filename);
		
		// Parse all shapes
		List<Shape> shapes = new List<Shape>();
		foreach(XmlNode shape in doc.SelectNodes("/shapes/*"))
		{
            Color stdColor = Color.Black;
            int width, height;
            int x = int.Parse(shape.Attributes["x"].Value);
            int y = int.Parse(shape.Attributes["y"].Value);
            switch (shape.Name)
            {
                case "rectangle":
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
                    shapes.Add(new Rectangle(x, y, width, height, stdColor));
                    break;
                case "circle":
					int size = int.Parse(shape.Attributes["size"].Value);
                    shapes.Add(new Circle(x, y, size, size, stdColor));
                    break;
				case "star":
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
					shapes.Add (new Star(x, y, width, height, stdColor));
					break; 
            }
		}		
		return shapes;
	}
}