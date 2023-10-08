using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows.infrastructure
{
  internal class State
  {
    public bool IsRunning { get; set; }

    public State() => IsRunning = true;
  }
}
