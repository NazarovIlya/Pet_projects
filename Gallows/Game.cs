using System;
using System.Collections.Generic;
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

			Render render = new Render(this.Y, this.X, this.linesCount);
            render.VerticalSymbol = "||";
            render.HorizontalSymbol = "=";
            render.RopeSymbol = "|";

			render.Draw(4);

            string word = "fddgwgdmv";

            string current = words.GetEncodingWord(word);
            Console.WriteLine(current);

            current = words.GetUpdatedWord(word, current, 'd');
            Console.WriteLine(current);

            current = words.GetUpdatedWord(word, current, 'g');
            Console.WriteLine(current);
        }
    }
}
