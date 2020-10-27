using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventure
{
    class Spiller
    {
        public List<string> har;
        public Rom rom;

        public Spiller()
        {
            har = new List<string>();
        }

        public string inventory()
        {
            return string.Join("\n", har);
        }
    }
}
