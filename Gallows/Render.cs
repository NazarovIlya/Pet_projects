﻿using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
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
		public Render(int x, int y, int linesCount)
		{
			this.x = x;
			this.y = y;
			this.lineCount = linesCount;
			view = new View();
			Console.WindowHeight = 40;
		}

		public void Draw(int count)
		{
			if (count != 0)
				DrawGallows(count);
		}
		private void DrawGallows(int count)
		{
            if (count >= 1)
            {
				this.x = 1; this.y = 0;
				for (int i = 0; i < this.lineCount; i++)
				{
					Console.SetCursorPosition(this.x, this.y++);
					view.WriteSymbolToConsole(string.Join("",  Enumerable.Repeat(VerticalSymbol, 2)));
				}
			}
            if (count >= 2)
            {
				this.x = 1; this.y = 0;
				for (int i = 0; i < this.lineCount * 1.25; i++)
				{
					Console.SetCursorPosition(++x, y);
					this.view.WriteSymbolToConsole(HorizontalSymbol);

				}
			}
			int temp = this.y += 1;
			if (count >= 3)
			{
				for (int i = 0; i < 2; i++)
				{
					Console.SetCursorPosition(this.x, this.y++);
					this.view.WriteSymbolToConsole(VerticalSymbol);
				}
			}
			this.x -= temp;
            if (count >= 4)
            {
				Console.SetCursorPosition(this.x, this.y++);
				this.view.WriteSymbolToConsole(string.Join("", Enumerable.Repeat(VerticalSymbol, 3)));
            }
			this.x += temp;
			if (count >= 5)
			{
				Console.SetCursorPosition(this.x - 2, this.y);
				for (int i = 0; i <= 4; i++)
				{
					this.view.WriteSymbolToConsole(HorizontalSymbol);
					Console.SetCursorPosition(++this.x - 2, this.y);
				}
				this.y += 1;
				for (int i = 0; i < 3; i++)
				{
					Console.SetCursorPosition(this.x - 7, this.y++);
					this.view.WriteSymbolToConsole(this.VerticalSymbol);
				}
				this.x += 4; this.y -= 3;
				for (int i = 0; i < 2; i++)
				{
					Console.SetCursorPosition(this.x - 7, this.y++);
					this.view.WriteSymbolToConsole(this.VerticalSymbol);
				}
				if (count >= 6)
				{
					this.x -= 10;
					for (int i = 0; i <= 4; i++)
					{
						Console.SetCursorPosition(++this.x - 2, this.y);
						this.view.WriteSymbolToConsole(HorizontalSymbol);
					}
				}
                if (count >= 7)
                {
					Console.SetCursorPosition(this.x - 9, this.y - 2);
					Console.WriteLine(string.Join("", Enumerable.Repeat(HorizontalSymbol, 3)));
					Console.SetCursorPosition(this.x - 1, this.y - 2);
					Console.WriteLine(string.Join("", Enumerable.Repeat(HorizontalSymbol, 3)));

					Console.SetCursorPosition(this.x - 5, this.y + 1);
                    Console.WriteLine(VerticalSymbol);
					Console.SetCursorPosition(this.x - 3, this.y + 1);
					Console.WriteLine(VerticalSymbol);


                }
            }
			Console.SetCursorPosition(0, this.lineCount + 1);
		}
		public void GameOver(int count)
		{
			Console.SetCursorPosition(0, this.lineCount + count + 2);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("GAME OVER!!!");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
