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
        private Description description;

        public Episode() { }
        public Episode(int a, double b, double c) { viewers = a; ratingsum = b; maxrating = c; }
        public Episode(int a, double b, double c, Description d) { viewers = a; ratingsum = b; maxrating = c;description = d; }

        public Random rnd = new Random();
        public void AddView(double a) { if (a > maxrating) maxrating = a; viewers += 1; }
        public delegate double Func(double x, double y);
        public static bool operator < (Episode ep1,Episode ep2)
        {
            if (ep1.GetAverageScore() < ep2.GetAverageScore())
                return true;
            else return false;
        }
        public static bool operator > (Episode ep1, Episode ep2)
        {
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
                return true;
            else return false;
        }
        public override string ToString()
        {
            return $"{viewers},{ratingsum},{maxrating},{description}";
        }
        public double GetAverageScore() { return ratingsum/viewers; }
        public int GetViewerCount() { return viewers; }
        public double GetMaxScore() { return maxrating; }

    }
    
    
}