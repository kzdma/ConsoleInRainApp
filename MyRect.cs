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
		#region Properties	
		public Point Vertex { get; set; } // קודקוד של המלבן שמאלי עליון
		public int Height {  get; set; }
		public int Width { get; set; }
		public ConsoleColor Color {  get; set; }

		#endregion

	
		//Default constructor - biuld a rectangle with random values
		public MyRect()
		{
			//Random Rectangle
			//Random rnd = new Random();
			//Height = rnd.Next(3, 10);
			//Width = rnd.Next(3, 10);
			//Color = (ConsoleColor)rnd.Next(1, 16);
			//Vertex = new Point(
			//	rnd.Next(1, Console.WindowWidth - Width), 
			//	rnd.Next(1, Console.WindowHeight - Height));
			
			
			Height = 8;
			Width = 16;
			Color = ConsoleColor.Yellow;
			Vertex = new Point(3, 4);
		}
		public MyRect(Point vertex, int height, int width, ConsoleColor color)
		{
			Vertex = vertex;
			Height = height;
			Width = width;
			Color = color;
		}
		public override string ToString()
		{
			return $"Vertex: {Vertex}\nHeight: {Height}\nWidth: {Width}\nColor: {Color}";
		}		
		public void UnDraw()
		{
			//DrawRectangle(ConsoleColor.Black);
			DrawRectangleCycle(ConsoleColor.Black);
		}
		public void Draw()
		{
			//DrawRectangle(this.Color);
			DrawRectangleCycle(this.Color);
		}
		private void DrawRectangle(ConsoleColor color)
		{
			//Console.Clear();
			if (Width < 2 || Height < 2) return; // Prevent crashes with impossible dimensions

			Console.ForegroundColor = color;

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
			string horizontalBar = new string(hLine, Width - 2);

			int temp = Console.WindowWidth;
			Console.SetCursorPosition(Vertex.X, Vertex.Y-1); Console.Write(Vertex.X + " ");

			Console.SetCursorPosition(Vertex.X, Vertex.Y);  
			Console.Write(tl + horizontalBar + tr); // Top edge

			Console.SetCursorPosition(Vertex.X, Vertex.Y + Height - 1);
			Console.Write(bl + horizontalBar + br); // Bottom edge

			//// --- 2. Draw Vertical Borders ---
			for (int i = 1; i < Height - 1; i++)
			{
				//Console.SetCursorPosition(_vertex.X, _vertex.X == 0 ? _vertex.Y + i : _vertex.X + 0); // Guarding cursor tracking
				Console.SetCursorPosition(Vertex.X, Vertex.Y + i);
				Console.Write(vLine);

				// Right Wall
				Console.SetCursorPosition(Vertex.X + Width - 1, Vertex.Y + i);
				Console.Write(vLine);
			}
			Console.WriteLine();
			Console.WriteLine();
		}
		public void MoveRight()
		{
			//int maxX = Console.WindowWidth - Width - 1;

			//if (Vertex.X >= maxX)
			//	return;

			//UnDraw();

			//int newX = Math.Min(, maxX);
			//Vertex = new Point(newX, Vertex.Y);

			//Draw();	

			UnDraw();
			Vertex = new Point(Vertex.X + 1, Vertex.Y);
			Draw();
		}
		public void MoveLeft()
		{
			UnDraw();
			Vertex = new Point(Vertex.X - 1, Vertex.Y);
			Draw();
		}
		public void MoveUp()
		{
			UnDraw();
			Vertex = new Point(Vertex.X, Vertex.Y - 1);
			Draw();
		}
		public void MoveDown()
		{
			UnDraw();
			Vertex = new Point(Vertex.X, Vertex.Y + 1);
			Draw();
		}
		public void MoveRightCycle()
		{
			int maxX = Console.WindowWidth - Width - 1;

			UnDraw();

			if (Vertex.X + 2 <= maxX)
			{
				Vertex = new Point(Vertex.X + 2, Vertex.Y);
			}
			else
			{
				Vertex = new Point(0, Vertex.Y);
			}

			Draw();
		}
		public void UnDraw2()
		{
			for (int i = 0; i < Height; i++)
			{
				Console.SetCursorPosition(Vertex.X, Vertex.Y + i);
				Console.Write(new string(' ', Width));
			}
		}
		private void DrawRectangleCycle2(ConsoleColor color)
		{
			if (Width < 2 || Height < 2) return;

			Console.ForegroundColor = color;

			int windowWidth = Console.WindowWidth;

			char tl = '╔';
			char tr = '╗';
			char bl = '╚';
			char br = '╝';
			char hLine = '═';
			char vLine = '║';

			for (int row = 0; row < Height; row++)
			{
				for (int col = 0; col < Width; col++)
				{
					int x = (Vertex.X + col) % windowWidth;
					int y = Vertex.Y + row;

					if (y < 0 || y >= Console.WindowHeight)
						continue;

					char ch = ' ';

					if (row == 0)
					{
						if (col == 0) ch = tl;
						else if (col == Width - 1) ch = tr;
						else ch = hLine;
					}
					else if (row == Height - 1)
					{
						if (col == 0) ch = bl;
						else if (col == Width - 1) ch = br;
						else ch = hLine;
					}
					else
					{
						if (col == 0 || col == Width - 1)
							ch = vLine;
						else
							continue;
					}

					Console.SetCursorPosition(x, y);
					Console.Write(ch);
				}
			}
		}
		private void DrawRectangleCycle(ConsoleColor color)
		{
			if (Width < 2 || Height < 2) return;

			Console.ForegroundColor = color;

			int windowWidth = Console.WindowWidth;
			int windowHeight = Console.WindowHeight;

			char tl = '╔';
			char tr = '╗';
			char bl = '╚';
			char br = '╝';
			char hLine = '═';
			char vLine = '║';

			for (int row = 0; row < Height; row++)
			{
				for (int col = 0; col < Width; col++)
				{
					int x = ((Vertex.X + col) % windowWidth
							 + windowWidth) % windowWidth;

					int y = ((Vertex.Y + row) % windowHeight
							 + windowHeight) % windowHeight;

					char ch = ' ';

					if (row == 0)
					{
						if (col == 0) ch = tl;
						else if (col == Width - 1) ch = tr;
						else ch = hLine;
					}
					else if (row == Height - 1)
					{
						if (col == 0) ch = bl;
						else if (col == Width - 1) ch = br;
						else ch = hLine;
					}
					else
					{
						if (col == 0 || col == Width - 1)
							ch = vLine;
						else
							continue;
					}

					Console.SetCursorPosition(x, y);
					Console.Write(ch);
				}
			}

			Console.ResetColor();
		}
	}
}
	