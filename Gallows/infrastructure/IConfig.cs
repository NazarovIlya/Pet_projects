using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
  internal interface IConfig
  {
    public int X { get; }
    public int Y { get; }
    public int LinesCount { get; }
    public string FileName { get; }
    public int WindowHeight { get; }
    public int WordLength { get; }
    public int MinWordsCount { get; }
    public char LetterSymbol { get; }
    string VerticalSymbol { get; }
    public string HorizontalSymbol { get; }
  }
}
