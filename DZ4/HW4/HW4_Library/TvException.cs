using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HW4_Library
{
    [Serializable]
    public class TvException : Exception
    {
        public string title;
        public TvException() { }
        public TvException(string message,string title) : base(message){ this.title = title; }
        public TvException(string message, Exception innerException) : base(message,
            innerException) { }
        protected TvException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
        public string Title{
            get =>title;
           
        }

    }
}
