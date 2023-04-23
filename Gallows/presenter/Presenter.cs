using Gallows.infrastructure.Commands;
using Gallows.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = Gallows.infrastructure.Commands.ICommand;

namespace Gallows.model
{
	internal class Presenter
	{
		public void StartGame()
		{
			IConfigDTO configDTO = new AppConfigDTO();
			IDictionary dictionary = new DictionaryService();
			IView view = new ConsoleView();			
			IRender render = new ConsoleRender(
											configDTO.X,
											configDTO.Y,
											configDTO.LinesCount,
											configDTO.WindowHeight);

			Game game = new Game(configDTO, 
				dictionary, 
				view, 
				render);

			List<ICommand> commands = new List<ICommand>();
			commands.Add(new QuiteCommand());
			commands.Add(new StartGameCommand());

			while (true)
			{
				int index = view.Menu(commands);
				commands[index].Execute(game);
			}
		}
	}
}
