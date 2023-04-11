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
        private string word;
        private string[] wordsArray;

        public Words(char symbol)
        {
            this.symbol = symbol;
            word = string.Empty;
            wordsArray = FillWordsArray();
        }
        public string Word { get => word = GetWord(); private set => word = value; }
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
                str += symbol;
            return str;
        }
        public string GetUpdatedWord(string word, string currentWord, char c)
        {
            string newCurrent = string.Empty;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (word[i] == c && currentWord[i] == symbol)
                    newCurrent += c;
                else
                    newCurrent += currentWord[i];
            }
            return newCurrent;
        }
    }
}
