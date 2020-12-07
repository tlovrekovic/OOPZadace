using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _3rdHomeworkLibrary
{
    public class Season
    {
        List<Episode> seasonList = new List<Episode>();
        int seasonNum;
        public Season(int seasonNum, Episode[] episodeArr)
        {
            this.seasonNum = seasonNum;
            for (int i = 0; i < episodeArr.Length; i++)
            {
                seasonList.Add(episodeArr[i]);
            }

        }
        public override string ToString()
        {
            string str = String.Join(", \n", seasonList);
            return $"Season {seasonNum}:\n================================================= \n{str}\nReport:\n=================================================" +
                $"\nTotal viewers {SumOfViews()}: \nTotal duration:{Duration()}\n=================================================";

        }
        int SumOfViews()
        {
            int viewers = 0;
            foreach (Episode ep in seasonList)
            { viewers += ep.GetViewerCount(); }
            return viewers;
        }
        TimeSpan Duration()
        {
            TimeSpan duration;
            foreach (Episode ep in seasonList)
            { duration = duration + ep.GetDuration(); }
            return duration;
        }

        public Episode this[int index]
        {
            get => seasonList[index];
            set => seasonList[index] = value;
        }
        public int Length
        {

            get => seasonList.Count;
        }


    }
}
