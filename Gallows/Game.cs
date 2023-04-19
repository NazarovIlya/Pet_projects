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
            Console.Clear();

            Words words = new Words("//..//..//..//dict.txt", '*');
            ConsoleView view = new ConsoleView();
            Render render = new Render(this.Y, this.X, this.linesCount, 40);
            render.VerticalSymbol = "|";
            render.HorizontalSymbol = "=";

            string word = words.Word;
            string current = words.GetEncodingWord(word);

            view.ShowWord(word);

            int count = 0;
            int lineNumber = 0;
            while (render.IsOver)
            {
                ++lineNumber;
                Console.SetCursorPosition(0, linesCount + 1);
                Console.WriteLine("Enter a letter:");
                char letter = view.GetChar();
                Console.SetCursorPosition(0, linesCount + lineNumber + 2);
                current = words.GetUpdatedWord(word, current, letter);
                Console.WriteLine();
                view.ShowWord(current);
                if (!words.IsLetter(current, letter))
                    count++;
                render.Draw(count);
                if (word == current)
                {
                    Console.SetCursorPosition(0, linesCount + word.Length + count + 3);
                    view.WriteCongratulations();
                    break;
                }
            }
        }
    }
}
