﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.infrastructure.Commands
{
	internal class QuiteCommand : ICommand
	{
		public string Discription() => "Select and push to quite game.";

		public void Execute(Game game) => Game.IsOver = true;
	}
}
