using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
  internal class AppConfig : IConfig
  {
    private static AppConfig? instance;
    public static AppConfig Instance
      => instance ??= new AppConfig();
    public int X { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("x")); }
    public int Y { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("y")); }
    public int LinesCount { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("linesCount")); }
    public string FileName { get => ConfigurationManager.AppSettings.Get("dictionary"); }
    public int WindowHeight { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("windowHeight")); }
    public int WordLength { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("wordLength")); }
    public int MinWordsCount { get => Convert.ToInt32(ConfigurationManager.AppSettings.Get("minWordsCount")); }
    public char LetterSymbol { get => Convert.ToChar(ConfigurationManager.AppSettings.Get("letterSymbol")); }
    public string VerticalSymbol { get => ConfigurationManager.AppSettings.Get("verticalSymbol"); }
    public string HorizontalSymbol { get => ConfigurationManager.AppSettings.Get("horizontalSymbol"); }
  }
}
