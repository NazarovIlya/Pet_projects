/* 1. При старте, приложение предлагает начать новую игру или выйти из приложения
 * 2. При начале новой игры, случайным образом загадывается слово,
 * и игрок начинает процесс по его отгадыванию
 * 3. После каждой введенной буквы выводим в консоль счётчик ошибок,
 * текущее состояние виселицы (нарисованное ASCII символами)
 * 4. По завершении игры выводим результат (победа или поражение) и возвращаемся к состоянию #1, 
 * то есть предложению начать новую игру или выйти из приложения.*/

using Gallows;

Render render = new Render();

Words words = new Words('*');
Console.WriteLine(words.Word);
Console.WriteLine(words.Word);
Console.WriteLine(words.Word); 
Console.WriteLine(words.Word);
Console.WriteLine(words.Word);
Console.WriteLine(words.Word);

string word = "fddgwgdmv";

render.Draw(1);

string current = words.GetEncodingWord(word);
Console.WriteLine(current);

current = words.GetUpdatedWord(word, current, 'd');
Console.WriteLine(current);

current = words.GetUpdatedWord(word, current, 'g');
Console.WriteLine(current);

