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
		public Render()
		{
			this.x = 0;
			this.y = 0;
		}

		public void Draw(int count)
		{
			if (count != 0)
				DrawGallows(count);
		}
		private void DrawGallows(int count)
		{
			Console.Clear();
			int curr = 0;
			this.x = 1; this.y = 0;	
			for (int i = 0; i < 12; i++)
			{
				Console.SetCursorPosition(x, y++);
				Console.WriteLine("||");
			}

			this.x = 1; this.y = 0;
			for (int i = 0; i < 18; i++)
			{
				Console.SetCursorPosition(++x, y);
				Console.WriteLine("=");
				
			}
			
			for (int i = 0; i < 2; i++)
			{
				Console.SetCursorPosition(this.x, 1);
				Console.WriteLine("|");
			}
				
			Console.SetCursorPosition(0, 14);
        }
	}
}
