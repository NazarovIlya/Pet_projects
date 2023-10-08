using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.infrastructure.Commands
{
  internal class QuiteCommand : ICommand
  {
    State state;
    public QuiteCommand(State state)
    {
      this.state = state;
    }
    public string Discription() => "Select and push to quite game.";

    public void Execute() => state.IsRunning = false;
  }
}
