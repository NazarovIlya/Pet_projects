using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class Render
	{
		private int x;
		private int y;
		private int lineCount;
		public Render(int x, int y, int linesCount)
		{
			this.x = x;
			this.y = y;
			this.lineCount = linesCount;
		}

		public void Draw(int count)
		{
			if (count != 0)
				DrawGallows(count);
		}
		private void DrawGallows(int count)
		{
			this.x = 1; this.y = 0;	
			for (int i = 0; i < this.lineCount; i++)
			{
				Console.SetCursorPosition(x, y++);
				Console.WriteLine("||");
			}

			this.x = 1; this.y = 0;
			for (int i = 0; i < this.lineCount * 1.5; i++)
			{
				Console.SetCursorPosition(++x, y);
				Console.WriteLine("=");
				
			}
			
			for (int i = 0; i < 2; i++)
			{
				Console.SetCursorPosition(this.x, 1);
				Console.WriteLine("|");
			}
				
			Console.SetCursorPosition(0, ++this.lineCount);
		}
	}
}
