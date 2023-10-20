using Gallows.infrastructure;
using Gallows.infrastructure.Commands;
using ICommand = Gallows.infrastructure.Commands.ICommand;

namespace Gallows.model
{
  internal class Presenter
  {
    private IView view;
    private State state;
    private List<ICommand> commands;
    public Presenter()
    {
      view = new ConsoleView();
      state = new State();
      commands = new List<ICommand>
      {
        new QuiteCommand(state),
        new StartGameCommand(view, state)
      };
    }
    public void StartGame()
    {
      while (state.IsRunning)
      {
        int index = view.Menu(commands);
        commands[index].Execute();
      }
    }
  }
}
