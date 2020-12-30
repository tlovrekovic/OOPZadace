using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace HW4_Library
{
    public class Season:IEnumerable<Episode> 
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
        public Season(int seasonNum, List<Episode> EpisodeList)
        {
            this.seasonNum = seasonNum;
            foreach(Episode ep in EpisodeList)
            {
                seasonList.Add(ep);
            }

        }
        public Season DeepCopy()
        {
            Season deepCopySeason = new Season(this.seasonNum,
                                 this.seasonList);
            return deepCopySeason;
        }
        public Season(Season other)
        {
            
            
                seasonNum = other.seasonNum;
                seasonList = new List<Episode>();
                seasonList.AddRange(other.seasonList);
           
                     
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
        public void Add(Episode Ep) { seasonList.Add(Ep); }
        public void Remove(string key)
        {
            var result = seasonList.Find(x => x.Name == key);
            if (result == null)
            {
                throw new TvException($"No such episode found. ",key);
                //TvException greska = new TvException();
                //greska.title = key;
            }
            else
            {
                seasonList.RemoveAll(x => x.Name == key);
                
            }


        }
        public IEnumerator<Episode> GetEnumerator()
        {
            foreach (Episode episode in seasonList)
            {
                yield return episode;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
