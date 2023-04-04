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
			FillWordsArray();
		}
		public string Word { get => word = GetWord(); private set => Word = word; }
		private void FillWordsArray()
		{
			this.wordsArray = new string[]
			{
				"word 1",
				"word 2"
			};
		}
		private string GetWord() => wordsArray[Random.Shared.Next(wordsArray.Length)];
	}
}
