using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInRainApp
{
	// מחלקה המייצגת מלבן
	public class MyRect
	{
		//קודקוד
		private Point _vertex; // קודקוד של המלבן שמאלי עליון
		private int _height;
		private int _width;
		private ConsoleColor _color;

		public MyRect(Point vertex, int height, int width, ConsoleColor color)
		{
			_vertex = vertex;
			_height = height;
			_width = width;
			_color = color;
		}

		public override string ToString()
		{
			return $"Vertex: {_vertex}\nHeight: {_height}\nWidth: {_width}\nColor: {_color}";
		}
	}
}
	