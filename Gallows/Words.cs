using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class Words
	{
		private string word;
		private string[] wordsArray;

		public Words()
		{
			this.word = string.Empty;
			this.wordsArray = FillWordsArray();
		}
		public string Word { get => word = GetWord(); private set => Word = word; }
		private string[] FillWordsArray()
		{
			string[] words = new string[]
			{
				"word 1",
				"word 2",
				"word 3",
				"word 4",
				"word 5"
			};
			return words;
		}
		private string GetWord() => wordsArray[Random.Shared.Next(wordsArray.Length)];
		public string GetEncodingWord(string word)
		{
			string str = string.Empty;
			for (int i = 0; i < word.Length; i++)
				str += '*';
			return str;
		}
		public string GetUpdatedWord(string word, string currentWord, char c)
		{
			string newCurrent = string.Empty;
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == c && currentWord[i] == '*')
					newCurrent += c;
				newCurrent += currentWord[i];
			}
		return newCurrent;
		}
	}
}
