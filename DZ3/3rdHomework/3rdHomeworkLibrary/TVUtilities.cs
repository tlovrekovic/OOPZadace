using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;
namespace _3rdHomeworkLibrary
{
    public class TvUtilities
    {

        public static void Sort(Episode[] episodes)
        {
            int n = episodes.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (episodes[j].GetAverageScore() < episodes[j + 1].GetAverageScore())
                    {
                        Episode temp = episodes[j];
                        episodes[j] = episodes[j + 1];
                        episodes[j + 1] = temp;
                    }
                }

            }
        }
        public static Episode Parse(string episodesInputs)
        {
            //0=viewers,1=sum,2=max,4=lenght,5=name
            Episode tmp = new Episode();
            string[] variables = episodesInputs.Split(',');
            Description descriptiontmp = new Description(int.Parse(variables[3]), TimeSpan.Parse(variables[4]), variables[5]);
            //za hrvatski cultureinfo ispisuje zarez
            return new Episode(int.Parse(variables[0]), double.Parse(variables[1], CultureInfo.InvariantCulture), double.Parse(variables[1], CultureInfo.InvariantCulture), descriptiontmp);
        }
        public static double GenerateRandomScore(int minimum, int maximum)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 5);
        }
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * 10, 5);
        }
        public static Episode[] LoadEpisodesFromFile(string filename)
        {
            string[] epizodeFajl = File.ReadAllLines(filename);
            Episode[] episodes = new Episode[epizodeFajl.Length];
            for (int i = 0; i < episodes.Length; i++)
            {
                episodes[i] = TvUtilities.Parse(epizodeFajl[i]);
            }
            return episodes;
        }
    }
}