using System;

namespace ConsoleAdventure
{
    class Program
    {
        private static Model model;

        static void Main(string[] args)
        {
            model = new Model();
            while (true)
            {
                UpdateView();
                Console.Write("Angi kommando: ");
                var command = Console.ReadLine();
                //if(command.StartsWith("Låse opp")) 
                //if(command.StartsWith("Gå gjennom")) 
            }
        }

        static void UpdateView()
        {
            var spiller = model.spiller;
            var rom = spiller.rom;
            var headerText = rom.vunnet
                ? "Gratulerer - du har fullført spillet! :-)"
                : $"Du er i rom {rom.navn}";
            Console.WriteLine(
                $"{headerText}\n\nI rommet ser du:{rom.hentInnhold()}\n\n" +
                $"Du har:{spiller.inventory()}\n\nDører:\n{model.doors()}");
        }
    }
}
