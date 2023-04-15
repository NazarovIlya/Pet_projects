using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
    internal class Game
    {
        public int Y { get; set; }
        public int X { get; set; }
        public int linesCount { get; set; }
        public Game(int y, int x, int linesCount)
        {
            this.Y = y;
            this.X = x;
            this.linesCount = linesCount;
        }

        public void StartGame()
        {
            
            Words words = new Words('*');
            Console.WriteLine(words.Word);
            Console.WriteLine(words.Word);
            Console.WriteLine(words.Word);
            Console.WriteLine(words.Word);
            Console.WriteLine(words.Word);
            Console.WriteLine(words.Word);

			Console.Clear();

			//(this.X, this.Y) = Console.GetCursorPosition(); //! TODO
            View view = new View();
			Render render = new Render(this.Y, this.X, this.linesCount);
            render.VerticalSymbol = "|";
            render.HorizontalSymbol = "=";

			//render.Draw(7);

			string word = words.Word;
			string current = words.GetEncodingWord(word);
			
			view.ShowWord(word);

			int count = 0;
            int lineNumber = 0;
			while (render.IsOver)
            {
                ++lineNumber;
				Console.SetCursorPosition(0, linesCount + lineNumber + 1);
				char letter = view.GetChar();
				Console.SetCursorPosition(0, linesCount + lineNumber + 1);
				current = words.GetUpdatedWord(word, current, letter); 
                Console.WriteLine();
                view.ShowWord(current);
                if (!words.IsLetter(current, letter))
                    count++;
				render.Draw(count);
			}

            

            


            current = words.GetUpdatedWord(word, current, 'd');
            Console.WriteLine(current);

            current = words.GetUpdatedWord(word, current, 'g');
            Console.WriteLine(current);


			current = words.GetUpdatedWord(word, current, 'f');
			Console.WriteLine(current);


			current = words.GetUpdatedWord(word, current, 'm');
			Console.WriteLine(current);


			current = words.GetUpdatedWord(word, current, 'v');
            Console.WriteLine(current);

			current = words.GetUpdatedWord(word, current, 'w');
			Console.WriteLine(current);


		}
    }
}
