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
    public IView View { get; set; }
    public State State { get; set; }
    public Presenter()
    {
      View = new ConsoleView();
      State = new State();
    }
    public void StartGame()
    {
      List<ICommand> commands = new List<ICommand>();
      commands.Add(new QuiteCommand(State));
      commands.Add(new StartGameCommand(View, State));

      while (State.IsRunning)
      {
        int index = View.Menu(commands);
        commands[index].Execute();
      }
    }
  }
}
