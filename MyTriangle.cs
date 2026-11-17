using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInRainApp
{
	public class MyTriangle
	{
		private Point _vertex; // קודקוד של המשולש שמאלי עליון
		private int _firstSide;
		private int _secondSide;
		private int _baseSide;
		private int _baseLeftangle;
		private int _baseRightangle;
		private ConsoleColor _color;

		public MyTriangle()
		{
			Random rnd = new Random();
			_firstSide = 5;
			_secondSide = 5;
			_baseSide = 5;		
			_color = (ConsoleColor)rnd.Next(1,16);

			_vertex = new Point(
				rnd.Next(1, Console.WindowWidth - 8),
				rnd.Next(1, Console.WindowHeight - 4));
		}

		public int GetHeight()
		{
			int area = (_firstSide * _secondSide) / 2;
			//int height = (int)Math.Sqrt(_firstSide * _firstSide - (_baseSide / 2) * (_baseSide / 2));
			
			int height = (int)(2 * area / _baseSide);
			return height;
		}
		

		public void Draw()
		{
			int height = GetHeight();
			if (height < 2) return;

			Console.ForegroundColor = _color;

			char left = '/';
			char right = '\\';
			char bottom = '_';

			for (int i = 0; i < height; i++)
			{
				int x = _vertex.X + height - i - 1;
				int y = _vertex.Y + i;

				Console.SetCursorPosition(x, y);

				if (i == height - 1)
				{
					Console.Write(left);
					Console.Write(new string(bottom, 2 * i));
					Console.Write(right);
				}
				else
				{
					Console.Write(left);
					Console.Write(new string(' ', 2 * i));
					Console.Write(right);
				}
			}
			Console.ResetColor();
		}
	}
}
