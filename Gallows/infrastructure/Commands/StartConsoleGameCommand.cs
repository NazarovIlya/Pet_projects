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
    State state;
    public StartGameCommand(IConfig config, IView view, State state)
    {
      this.dictionary = new DictionaryService();
      this.view = view;
      this.config = config;
      this.state = state;
      this.render = new ConsoleRender(this.state, 
        config.X, 
        config.Y,
        config.LinesCount,
        config.WindowHeight);
      
      this.game = new Game(this.state,
        this.config,
        this.dictionary,
        this.view,
        this.render,
        this.config.WordLength,
        this.config.MinWordsCount);
    }
    public string Discription() => "Select and push to start game.";

    public void Execute()
    {
      this.state.IsRunning = true;
      game.StartGame();
    }
  }
}
