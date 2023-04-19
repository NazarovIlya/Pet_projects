using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
    internal class Words
    {
        char symbol;
        private string[] wordsArray;

        public Words(string pathFile, char symbol)
        {
            this.Symbol = symbol;
            wordsArray = FillWordsArray(pathFile);
        }
        public string Word { get => GetWord(); }
		public char Symbol { get => symbol; set => symbol = value; }

		private string[] FillWordsArray(string pathFile)
        {
            string[] words;
            string path = AppDomain.CurrentDomain.BaseDirectory + pathFile;
			FileInfo fileInfo = new FileInfo(path);
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
        private string GetWord() => wordsArray[Random.Shared.Next(wordsArray.Length)];
        public string GetEncodingWord(string word)
        {
            string str = string.Empty;
            for (int i = 0; i < word.Length; i++)
                str += Symbol;
            return str;
        }
        public string GetUpdatedWord(string word, string currentWord, char c)
        {
            string newCurrent = string.Empty;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (word[i] == c && currentWord[i] == Symbol)
                    newCurrent += c;
                else
                    newCurrent += currentWord[i];
            }
            return newCurrent;
        }
  //      public bool IsAnyClosedLetter(string word)
  //      {
  //          for (int i = 0; i < word.Length; i++)
  //              if (word[i] == Symbol)
  //                  return true;
		//	return false;
		//}
        public bool IsLetter(string word, char letter)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                    return true;
            }
            return false;
        }
    }
}
