﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.infrastructure.Commands
{
	internal class StartGameCommand : ICommand
	{
		public string Discription() => "Select and push to start game.";

		public void Execute(Game game) => game.StartGame();
	}
}
