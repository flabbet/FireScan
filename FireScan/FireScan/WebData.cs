using System;
using System.Collections.Generic;
using System.Text;

namespace FireScan
{
    public struct WebData
    {
        public string Ccnt { get; set; }
        public int Timestamp { get; set; }
        public int V { get; set; }
        public List<Event> Events { get; set; }

        public WebData(string ccnt, int timestamp, int v, List<Event> events)
        {
            Ccnt = ccnt;
            Timestamp = timestamp;
            V = v;
            Events = events;
        }
    }
}
