using System;

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace HomeworkLibrary
{
    public class Episode
    {
        private int viewers = 0;
        private double ratingsum = 0;
        private double maxrating = 0;

        public Episode() { }
        public Episode(int a, double b, double c) { viewers = a; ratingsum = b; maxrating = c; }

        public Random rnd = new Random();
        public void AddView(double a) { if (a > maxrating) maxrating = a; viewers += 1; }
        public delegate double Func(double x, double y);
        public static double GenerateRandomNumber(int minimum, int maximum)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 5);
        }
        public double GetAverageScore() { return ratingsum /= viewers; }
        public int GetViewerCount() { return viewers; }
        public double GetMaxScore() { return maxrating; }

    }

}