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
    private Game? game;
    public StartGameCommand(IConfig config, IView view)
    {
      this.dictionary = new DictionaryService();
      this.view = view;
      this.config = config;
      this.render = new ConsoleRender(config.X, 
        config.Y,
        config.LinesCount,
        config.WindowHeight);
    }
    public string Discription() => "Select and push to start game.";

    public void Execute()
    {
      this.game = new Game(config,
        this.dictionary,
        this.view,
        this.render,
        this.config.WordLength,
        this.config.MinWordsCount);
      this.game.StartGame();
    }
  }
}
