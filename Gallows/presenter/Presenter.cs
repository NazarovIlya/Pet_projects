using Gallows.infrastructure;
using Gallows.infrastructure.Commands;
using ICommand = Gallows.infrastructure.Commands.ICommand;

namespace Gallows.model
{
  internal class Presenter
  {
    public IView View { get; set; }
    public State State { get; set; }
    public List<ICommand> Commands { get; set; }
    public Presenter()
    {
      View = new ConsoleView();
      State = new State();
      Commands = new List<ICommand>
      {
        new QuiteCommand(State),
        new StartGameCommand(View, State)
      };
    }
    public void StartGame()
    {
      while (State.IsRunning)
      {
        int index = View.Menu(Commands);
        Commands[index].Execute();
      }
    }
  }
}
