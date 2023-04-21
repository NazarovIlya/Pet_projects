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
    internal class ConsoleView : IView
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
