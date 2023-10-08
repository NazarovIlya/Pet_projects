using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
  internal interface IDictionary
  {
    public string[] GetWordsArray(string fileName, int wordLength, int minWordsCount);
  }
}
