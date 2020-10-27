using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventure
{
    class Rom
    {
        public string navn;
        public string[] innhold;
        public bool start;
        public bool vunnet;

        public string hentInnhold()
        {
            return string.Join("\n", innhold);
        }
    }
}
