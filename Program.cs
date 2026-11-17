

using ConsoleInRainApp;
using System.Drawing;


DrawRandomRectangle2();

void DrawRandomRectangle2()
{
	MyRect myRect;

	while (true)
	{
		myRect = new MyRect();
		myRect.Draw();
		Thread.Sleep(150);
	}
}

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