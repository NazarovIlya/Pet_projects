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
		public int Y { get; private set; }
		public int X { get; private set; }
		public int LinesCount { get; private set; }
		public string FileName { get; private set; }
		public int WindowHeight { get; private set; }
		public char LetterSymbol { get; private set; }
		public string VerticalSymbol { get; private set; }
		public string HorizontalSymbol { get; private set; }
		public string[] Dictionary { get; private set; }
		internal IDictionary DictionaryService {get; private set; }
		internal Words Words { get; private set; }
		internal IView View { get; private set; }
		internal IRender Render { get; private set; }

		public Game(IConfigDTO configDTO, IDictionary dictionaryService, IView view, IRender render)
		{
			this.Y = configDTO.Y;
			this.X = configDTO.X;
			this.LinesCount = configDTO.LinesCount;
			this.FileName = configDTO.FileName;
			this.WindowHeight = configDTO.WindowHeight;
			this.LetterSymbol = configDTO.LetterSymbol;
			this.VerticalSymbol = configDTO.VerticalSymbol;
			this.HorizontalSymbol = configDTO.HorizontalSymbol;

			this.DictionaryService = dictionaryService;
			this.Dictionary = dictionaryService.GetWordsArray(this.FileName);
			this.Words = new Words(this.Dictionary, this.LetterSymbol);
			this.View = view;
			this.Render = render;
		}

		public void StartGame()
		{
			Console.Clear();

			Render.VerticalSymbol = this.VerticalSymbol;
			Render.HorizontalSymbol = this.HorizontalSymbol;

			string word = Words.Word;
			string current = Words.GetEncodingWord(word);

			int count = 0;
			int lineNumber = 0;
			while (!Render.IsOver)
			{
				++lineNumber;
				Console.SetCursorPosition(0, LinesCount + 3);
				View.PromtForInput();
				char letter = View.GetChar();
				Console.SetCursorPosition(0, LinesCount + lineNumber + 3);
				current = Words.GetUpdatedWord(word, current, letter);
				Console.WriteLine();
				View.ShowWord(current);
				if (!Words.IsLetter(current, letter))
					count++;
				Render.Draw(count);
				if (word == current)
				{
					Console.SetCursorPosition(0, LinesCount + 1);
					View.WriteCongratulations();
					break;
				}
			}		
			Console.SetCursorPosition(0, LinesCount + word.Length + count);
			Render.IsOver = false;
		}
	}
}
