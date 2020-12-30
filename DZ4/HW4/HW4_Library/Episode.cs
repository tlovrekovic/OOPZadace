using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW4_Library
{
    public class Episode
    {
        private int viewers = 0;
        private double ratingsum = 0;
        private double maxrating = 0;
        private Description description;

        List<Episode> episodes = new List<Episode>();
        public Episode() { }
        public Episode(int viewers, double ratingsum, double maxrating) { this.viewers = viewers; this.ratingsum = ratingsum; this.maxrating = maxrating; }
        public Episode(int viewers, double ratingsum, double maxrating, Description description) { this.viewers = viewers; this.ratingsum = ratingsum; this.maxrating = maxrating; this.description = description; }

        public Random rnd = new Random();
        public void AddView(double rating) { viewers += 1; ratingsum += rating; if (maxrating < rating) { maxrating = rating; } }
        public delegate double Func(double x, double y);
        public static bool operator <(Episode ep1, Episode ep2)
        {
            if (ep1.GetAverageScore() < ep2.GetAverageScore())
                return true;
            else return false;
        }
        public static bool operator >(Episode ep1, Episode ep2)
        {
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
                return true;
            else return false;
        }

        public override string ToString()
        {
            return $"{viewers}, {ratingsum}, {maxrating}, {description}";
        }
        public Description Description
        {

            get => description;
        }
        public string Name
        {
            get => Description.Name;
        }
        public double GetAverageScore() { return ratingsum / viewers; }
        public int GetViewerCount() { return viewers; }
        public double GetMaxScore() { return maxrating; }
        public TimeSpan GetDuration() { return description.Runtime; }

    }
}
