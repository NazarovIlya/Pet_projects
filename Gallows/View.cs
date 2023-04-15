using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gallows
{
	internal class View
	{
		public void Menu(List<ICommand> commands) { }
		public char GetChar()
		{
			bool flag = true;
			string letter = string.Empty;
			while (flag) 
			{
				letter = Console.ReadLine();
                if (!string.IsNullOrEmpty(letter) && letter.Length == 1)
					flag = false;
			}
			return letter[0];
		}
		public void ShowWord(string word) => Console.WriteLine(word);
		public void WriteSymbolToConsole(string symbol) => Console.WriteLine(symbol);
	}
}
