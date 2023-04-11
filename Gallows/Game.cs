using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
	internal class Game
	{
		public Game() { }

		public void StartGame()
		{
			Render render = new Render(0, 0, 12);

			Words words = new Words('*');
			Console.WriteLine(words.Word);
			Console.WriteLine(words.Word);
			Console.WriteLine(words.Word);
			Console.WriteLine(words.Word);
			Console.WriteLine(words.Word);
			Console.WriteLine(words.Word);

			string word = "fddgwgdmv";

			render.Draw(1);

			string current = words.GetEncodingWord(word);
			Console.WriteLine(current);

			current = words.GetUpdatedWord(word, current, 'd');
			Console.WriteLine(current);

			current = words.GetUpdatedWord(word, current, 'g');
			Console.WriteLine(current);
		}
	}
}
