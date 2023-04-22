using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.model
{
	internal class Presenter
	{
		public void StartGame()
		{
			IConfigDTO configDTO = new AppConfigDTO();

			Game game = new Game(configDTO, new DictionaryService(), new ConsoleView());

			game.StartGame();
		}
	}
}
