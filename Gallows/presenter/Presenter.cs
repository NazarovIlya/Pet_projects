﻿using Gallows.infrastructure.Commands;
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
			IConfig config = AppConfig.Instance;
			IView view = new ConsoleView();

			List<ICommand> commands = new List<ICommand>();
			commands.Add(new QuiteCommand());
			commands.Add(new StartGameCommand(config, view));

			//IDictionary dictionary = new DictionaryService();
						
			//IRender render = new ConsoleRender(config.X,
			//	config.Y,
			//	config.LinesCount,
			//	config.WindowHeight);

			//Game game = new Game(config,
			//	dictionary,
			//	view,
			//	render,
			//	config.WordLength,
			//	config.MinWordsCount);

			while (!Game.IsOver)
			{
				int index = view.Menu(commands);
				commands[index].Execute();
			}
		}
	}
}
