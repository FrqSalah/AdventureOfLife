using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureOfLife.AdventureBot
{
    class AdventureException :Exception
    {
        public AdventureException(string message) : base(message) { }
    }
}
