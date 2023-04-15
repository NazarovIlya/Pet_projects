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
		private View view;
		public string VerticalSymbol { get; set; }
		public string HorizontalSymbol { get; set; }
		public string RopeSymbol { get; set; }
		public Render(int x, int y, int linesCount)
		{
			this.x = x;
			this.y = y;
			this.lineCount = linesCount;
			view = new View();
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
				view.WriteSymbolToConsole(VerticalSymbol);
			}

			this.x = 1; this.y = 0;
			for (int i = 0; i < this.lineCount * 1.5; i++)
			{
				Console.SetCursorPosition(++x, y);
				this.view.WriteSymbolToConsole(HorizontalSymbol);
				
			}
			
			for (int i = 0; i < 2; i++)
			{
				Console.SetCursorPosition(this.x, 1);
				this.view.WriteSymbolToConsole(this.RopeSymbol);
			}
				
			Console.SetCursorPosition(0, ++this.lineCount);
		}
	}
}
