using System;
using System.IO;
using _3rdHomeworkLibrary;

namespace _3rdHomework
{
    class Program
    {
          
        static void Main()
        {
            //ulazna datoteka je u trajanju epizode drukcija,umjesto 00:45:00 pise samo 45.Program radi za 00:00:45
            string fileName = "shows.tv";
            string outputFileName = "storage.tv";

            IPrinter printer = new ConsolePrinter();
            printer.Print($"Reading data from file {fileName}");

            Episode[] episodes = TvUtilities.LoadEpisodesFromFile(fileName);
            Season season = new Season(1, episodes);

            printer.Print(season.ToString());
            for (int i = 0; i < season.Length; i++)
            {
                season[i].AddView(TvUtilities.GenerateRandomScore());
            }
            printer.Print(season.ToString());

            printer = new FilePrinter(outputFileName);
            printer.Print(season.ToString());
        }

    }

}
    
