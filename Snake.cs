using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInRainApp
{
	public class Snake
	{
		public int Length { get; set; }
		public Point Head {  get; set; }
		public int Height { get; set; }
		public int CellWidth { get; set; }

		private MyRect[] _body;

		public Snake() 
		{
			
			Length = 3; //Snake Length
			Height = 4;
			CellWidth = 8;
			Head = new Point(20,10);

			//Create Rectangles Array with Snake Length
			_body = new MyRect[Length];

			for (int i = 0; i < Length; i++)
			{
				_body[i] = new MyRect()
				{
					Height = this.Height,
					Width = CellWidth,
					Color = (ConsoleColor)new Random().Next(1, 16)
				};

				if (i == 0)
				{
					_body[i].Vertex = Head;
				}				
				else
				{
					_body[i].Vertex = new Point(_body[i - 1].Vertex.X + CellWidth + 1, Head.Y);
				}
			}	
		}

		public void Draw()
		{
			foreach(MyRect item in _body)
			{
				item.Draw();
			}
			
		}
	}
}
