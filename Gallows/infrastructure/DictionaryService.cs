using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class DictionaryService : IDictionary
	{
		public string[] GetWordsArray(string fileName, int wordLength, int minWordsCount)
		{
			string[] inputWords = null;
			string[] words = null;
			FileInfo fileInfo = new FileInfo(fileName);
			if (fileInfo.Exists)
			{
				inputWords = File.ReadAllLines(fileInfo.FullName);
			}
			words = (from word in inputWords
					 where word.Length >= wordLength
					 select word).ToArray();

			if (words.Length >= minWordsCount)
				return words;
			else
			{
				words = new string[]
				{
				"word 123",
				"word 2",
				"word 3",
				"word 4",
				"word 5"
				};
			}
			return words;
		}
	}
}
