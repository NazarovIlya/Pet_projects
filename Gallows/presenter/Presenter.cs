using Gallows.infrastructure;
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
      IView view = new ConsoleView();
      State state = new();

      List<ICommand> commands = new List<ICommand>();
      commands.Add(new QuiteCommand(state));
      commands.Add(new StartGameCommand(view, state));

      while (state.IsRunning)
      {
        int index = view.Menu(commands);
        commands[index].Execute();
      }
    }
  }
}
