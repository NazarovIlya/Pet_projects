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
        public int LinesCount { get; set; }
        public string FileName { get; set; }
        public int WindowHeight { get; set; }
        public char LetterSymbol { get; set; }
        string VerticalSymbol { get; set; }
        public string HorizontalSymbol { get; set; }
        public Game(IConfigDTO configDTO)
        {
            this.Y = configDTO.Y;
            this.X = configDTO.X;
            this.LinesCount = configDTO.LinesCount;
            this.FileName = configDTO.FileName;
            this.WindowHeight = configDTO.WindowHeight;
            this.LetterSymbol = configDTO.LetterSymbol;
            this.VerticalSymbol = configDTO.VerticalSymbol;
            this.HorizontalSymbol = configDTO.HorizontalSymbol;
        }

        public void StartGame()
        {
            Console.Clear();

            Words words = new Words(this.FileName, this.LetterSymbol);
            IView view = new ConsoleView();
            Render render = new Render(this.Y, this.X, this.LinesCount, this.WindowHeight);
            render.VerticalSymbol = VerticalSymbol;
            render.HorizontalSymbol = HorizontalSymbol;

            string word = words.Word;
            string current = words.GetEncodingWord(word);

            view.ShowWord(word);

            int count = 0;
            int lineNumber = 0;
            while (render.IsOver)
            {
                ++lineNumber;
                Console.SetCursorPosition(0, LinesCount + 1);
                Console.WriteLine("Enter a letter:");
                char letter = view.GetChar();
                Console.SetCursorPosition(0, LinesCount + lineNumber + 2);
                current = words.GetUpdatedWord(word, current, letter);
                Console.WriteLine();
                view.ShowWord(current);
                if (!words.IsLetter(current, letter))
                    count++;
                render.Draw(count);
                if (word == current)
                {
                    Console.SetCursorPosition(0, LinesCount + word.Length + count + 3);
                    view.WriteCongratulations();
                    break;
                }
            }
        }
    }
}
