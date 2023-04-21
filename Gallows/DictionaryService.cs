using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class DictionaryService : IDictionary
	{
		public string[] GetWordsArray(string fileName)
		{
			string[] words;
			FileInfo fileInfo = new FileInfo(fileName);
			if (fileInfo.Exists)
				words = File.ReadAllLines(fileInfo.FullName);
			else
			{
				words = new string[]
				{
				"word 1",
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
