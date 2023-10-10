using Gallows.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.infrastructure.Commands
{
  internal class StartGameCommand : ICommand
  {
    private IConfig config;
    private IDictionary dictionary;
    private IView view;
    private IRender render;
    private Game game;
    private State state;
    public StartGameCommand(IView view, State state)
    {
      this.state = state;
      this.view = view;
      config = AppConfig.Instance;
      dictionary = new DictionaryService();
      render = new ConsoleRender(state,
        view,
        config.X, 
        config.Y,
        config.LinesCount,
        config.WindowHeight);
      
      game = new Game(this.state,
        config,
        dictionary,
        view,
        render,
        config.WordLength,
        config.MinWordsCount);
    }
    public string Discription() => "Select and push to start game.";

    public void Execute()
    {
      this.state.IsRunning = true;
      game.StartGame();
    }
  }
}
