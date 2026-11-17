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

		//Default constructor
		public MyRect()
		{
			_vertex = new Point(1, 1); //default vertex
			_height = 8;
			_width = 16;
			_color = ConsoleColor.DarkCyan;
		}
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

		public void Draw()
		{
			//Console.Clear();
			if (_width < 2 || _height < 2) return; // Prevent crashes with impossible dimensions

			Console.ForegroundColor = _color;

			// --- Define the Box-Drawing Elements ---

			// -- Draw with single line box-drawing characters --

			//char tl = '┌'; // Top Left
			//char tr = '┐'; // Top Right
			//char bl = '└'; // Bottom Left (Your icon!)
			//char br = '┘'; // Bottom Right
			//char hLine = '─'; // Horizontal Line
			//char vLine = '│'; // Vertical Line

			// -- Draw with double line box-drawing characters --

			char tl = '╔'; // Top Left
			char tr = '╗'; // Top Right
			char bl = '╚'; // Bottom Left (Your icon!)
			char br = '╝'; // Bottom Right
			char hLine = '═'; // Horizontal Line
			char vLine = '║'; // Vertical Line


			// --- 1. Draw Top and Bottom Horizontal Borders ---
			string horizontalBar = new string(hLine, _width - 2);

			Console.SetCursorPosition(_vertex.X, _vertex.Y);
			Console.Write(tl + horizontalBar + tr); // Top edge

			Console.SetCursorPosition(_vertex.X, _vertex.Y + _height - 1);
			Console.Write(bl + horizontalBar + br); // Bottom edge

			//// --- 2. Draw Vertical Borders ---
			for (int i = 1; i < _height - 1; i++)
			{
				//Console.SetCursorPosition(_vertex.X, _vertex.X == 0 ? _vertex.Y + i : _vertex.X + 0); // Guarding cursor tracking
				Console.SetCursorPosition(_vertex.X, _vertex.Y + i);
				Console.Write(vLine);

				// Right Wall
				Console.SetCursorPosition(_vertex.X + _width - 1, _vertex.Y + i);
				Console.Write(vLine);
			}
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
	