using Gallows.infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = Gallows.infrastructure.Commands.ICommand;

namespace Gallows
{
	internal interface IView
	{
		public int Menu(List<ICommand> commands);
		public char GetChar();
		public void ShowWord(string word);
		public void WriteSymbol(string symbol);
		public void PromtForInput();
		public void WriteCongratulations();
		public void WriteGameOver();
	}
}
