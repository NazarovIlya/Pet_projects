using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace Gallows
{
  internal class Words
  {
    char symbol;

    public Words(string[] wordsArray, char symbol)
    {
      this.Symbol = symbol;
      this.WordsArray = wordsArray;
    }
    public string Word { get => GetRandomWord(); }
    public char Symbol { get => symbol; set => symbol = value; }
    public string[] WordsArray { get; private set; }
    private string GetRandomWord() => WordsArray[Random.Shared.Next(WordsArray.Length)];
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
        if (word.ToLower()[i] == char.ToLower(c) && currentWord[i] == Symbol)
          newCurrent += c;
        else
          newCurrent += currentWord[i];
      }
      return newCurrent;
    }
    public bool IsLetter(string word, char letter)
    {
      for(int i = 0; i < word.Length; i++)
      {
        if (word.ToLower()[i] == char.ToLower(letter))
          return true;
      }
      return false;
    }
  }
}
