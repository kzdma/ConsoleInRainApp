

using ConsoleInRainApp;
using System.Drawing;




MyRect myRect1 = new MyRect(new Point(10, 5), 4, 8, ConsoleColor.Yellow);
myRect1.Draw();

MyRect myRect2 = new MyRect();
myRect2.Draw();


//DrawRandomRectangle();

//void DrawRandomRectangle()
//{
//	MyRect myRect;
//	Random random = new Random();

//	int poor = random.Next(1, 50); // Rectangles quantity
//	for (int i = 0; i < poor; i++)
//	{
//		myRect = new MyRect(
//			new Point(random.Next(1,Console.WindowWidth - 8), 
//			          random.Next(1, Console.WindowHeight - 4)),
//			4, 8, ConsoleColor.Yellow);

//		Thread.Sleep(1000);
//		myRect.Draw();
//	}



//}