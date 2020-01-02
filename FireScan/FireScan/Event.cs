using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FireScan
{
    public struct Event
    {
        public string Status { get; set; }
        [JsonProperty("sub_name")]
        public string SubName { get; set; }
        public string Type { get; set; }
        [JsonProperty("ts")]
        public int Timestamp { get; set; }
        public int Votes { get; set; }
        [JsonProperty("com")]
        public int Comments { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        [JsonProperty("who")]
        public string Author { get; set; }
        public int Uid { get; set; }
        public int Id { get; set; }
        [JsonProperty("icon")]
        public string IconUrl { get; set; }

        public Event(string status, string subName, string type, int timestamp, int votes, int comments, string link, string title, string author, int uid, int id, string iconUrl)
        {
            Status = status;
            SubName = subName;
            Type = type;
            Timestamp = timestamp;
            Votes = votes;
            Comments = comments;
            Link = link;
            Title = title;
            Author = author;
            Uid = uid;
            Id = id;
            IconUrl = iconUrl;
        }
    }
}
