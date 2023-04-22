using Gallows.view;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class Game
    {
		IDictionary dictionaryService;
		string[] dictionary;
		Words words;
		IView view;
		IRender render;
		public int Y { get; private set; }
        public int X { get; private set; }
        public int LinesCount { get; private set; }
        public string FileName { get; private set; }
        public int WindowHeight { get; private set; }
        public char LetterSymbol { get; private set; }
        public string VerticalSymbol { get; private set; }
        public string HorizontalSymbol { get; private set; }
        public Game(IConfigDTO configDTO, IDictionary dictionaryService, IView view)
        {
            this.Y = configDTO.Y;
            this.X = configDTO.X;
            this.LinesCount = configDTO.LinesCount;
            this.FileName = configDTO.FileName;
            this.WindowHeight = configDTO.WindowHeight;
            this.LetterSymbol = configDTO.LetterSymbol;
            this.VerticalSymbol = configDTO.VerticalSymbol;
            this.HorizontalSymbol = configDTO.HorizontalSymbol;

            this.dictionaryService = dictionaryService;
			this.dictionary = dictionaryService.GetWordsArray(this.FileName);
			this.words = new Words(dictionary, this.LetterSymbol);
            this.view = view;
			this.render = new ConsoleRender(this.Y, this.X, this.LinesCount, this.WindowHeight);
		}

        public void StartGame()
        {
            Console.Clear();

            render.VerticalSymbol = this.VerticalSymbol;
            render.HorizontalSymbol = this.HorizontalSymbol;

            string word = words.Word;
            string current = words.GetEncodingWord(word);

            int count = 0;
            int lineNumber = 0;
            while (!render.IsOver)
            {
                ++lineNumber;
                Console.SetCursorPosition(0, LinesCount + 3);
                view.PromtForInput();
                char letter = view.GetChar();
                Console.SetCursorPosition(0, LinesCount + lineNumber + 3);
                current = words.GetUpdatedWord(word, current, letter);
                Console.WriteLine();
                view.ShowWord(current);
                if (!words.IsLetter(current, letter))
                    count++;
                render.Draw(count);
                if (word == current)
                {
                    Console.SetCursorPosition(0, LinesCount + 1);
                    view.WriteCongratulations();
                    break;
                }
            }			
            Console.Read();
            Console.SetCursorPosition(0, LinesCount + word.Length + count);
        }
    }
}
