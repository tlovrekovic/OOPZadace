using System;
using System.IO;

namespace HW4_Library
{
    public class Description
    {
        private int episodenumber = 0;
        private TimeSpan runtime;
        private string name;
        public override string ToString()
        {
            return $"{episodenumber},{runtime},{name}";
        }
        public Description(int en, TimeSpan rt, string description) { episodenumber = en; runtime = rt; name = description; }
        public string Name
        {
            get => name;
        }
        public TimeSpan Runtime
        {

            get => runtime;
        }



    }
}
