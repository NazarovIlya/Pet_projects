/* 1. При старте, приложение предлагает начать новую игру или выйти из приложения
 * 2. При начале новой игры, случайным образом загадывается слово,
 * и игрок начинает процесс по его отгадыванию
 * 3. После каждой введенной буквы выводим в консоль счётчик ошибок,
 * текущее состояние виселицы (нарисованное ASCII символами)
 * 4. По завершении игры выводим результат (победа или поражение) и возвращаемся к состоянию #1, 
 * то есть предложению начать новую игру или выйти из приложения.*/

using System.Configuration;
using Gallows;


Game game = new Game(Convert.ToInt32(ConfigurationManager.AppSettings.Get("x")),
					Convert.ToInt32(ConfigurationManager.AppSettings.Get("y")),
					Convert.ToInt32(ConfigurationManager.AppSettings.Get("linesCount")),
					Convert.ToInt32(ConfigurationManager.AppSettings.Get("windowHeight")),
					ConfigurationManager.AppSettings.Get("dictionary")!, 
					Convert.ToChar(ConfigurationManager.AppSettings.Get("letterSymbol")!),
					ConfigurationManager.AppSettings.Get("verticalSymbol")!,
					ConfigurationManager.AppSettings.Get("horizontalSymbol")!);

game.StartGame();

