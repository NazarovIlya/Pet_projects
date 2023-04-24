using Gallows.infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = Gallows.infrastructure.Commands.ICommand;

namespace Gallows
{
	internal class ConsoleView : IView
	{
		public int Menu(List<ICommand> commands)
		{
			for(int i = 0; i < commands.Count; i++)
			{
				Console.WriteLine($"{i} --> {commands[i].Discription()}");
			}
			return MenuIndex(commands);
		}
		private int MenuIndex(List<ICommand> commands)
		{
			bool flag = true;
			int index = 0;
			string? input = string.Empty;
			Regex regex = new Regex($"^[0-1]+$", RegexOptions.Compiled);
			while (flag)
			{
				Console.Write("Select a team number from the list:\t\n");
				input = Console.ReadLine();
				if (input.All(char.IsDigit) && regex.IsMatch(input))
				{
					index = int.Parse(input);
					flag = false;
				}				
			}
			return index;
		}
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
		public void ShowWord(string word) => Console.WriteLine(word.ToUpper());
		public void WriteSymbol(string symbol) => Console.WriteLine(symbol);
		public void PromtForInput() => Console.WriteLine("Enter a letter:");
		public void WriteCongratulations()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Our Congratulations! You are the best!!!");
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void WriteGameOver()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("GAME OVER!!!");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
