using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAdventure
{
    class Model
    {
        public Spiller spiller;
        public Rom[] rom;
        public Dør[] dører;

        public Model()
        {
            spiller = new Spiller();
            var romA = new Rom { navn = "A", innhold = new[] { "rød nøkkel" }, start = true };
            var romB = new Rom { navn = "B", innhold = new[] { "grønn nøkkel" } };
            var romC = new Rom { navn = "C", innhold = new[] { "hvit nøkkel" } };
            var romD = new Rom { navn = "D", innhold = new[] { "blå nøkkel" } };
            var romE = new Rom { navn = "E", innhold = new[] { "grå nøkkel" } };
            var romF = new Rom { navn = "F", innhold = new string[0], vunnet = true };
            rom = new[] { romA, romB, romC, romD, romE, romF, };
            spiller.rom = rom.FirstOrDefault(r => r.start);
            dører = new[]
            {
                new Dør{ A= romB, B= romA, farge= "rød", åpen= false },
                new Dør{ A= romD, B= romA, farge= "grønn", åpen= false },
                new Dør{ A= romC, B= romB, farge= "grå", åpen= false },
                new Dør{ A= romE, B= romB, farge= "blå", åpen= false },
                new Dør{ A= romF, B= romE, farge= "hvit", åpen= false },
            };
        }

        public string doors()
        {
            var rom = spiller.rom;
            var dørerIRommet = dører.Where(d => d.A == rom || d.B == rom);

            var txt = "";
            foreach (var dør in dørerIRommet)
            {
                var til = dør.A == rom ? dør.B : dør.A;
                txt += dør.åpen
                    ? $"Gå til {til.navn}\n"
                    : $"Låse opp {dør.farge}\n";
            }
            return txt;
        }
    }
}
