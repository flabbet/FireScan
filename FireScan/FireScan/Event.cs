using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace FireScan
{
    public class Event
    {
        [Key]
        public int PrimaryId { get; set; }
        public string Status { get; set; }
        [JsonProperty("sub_name")]
        public string SubName { get; set; }
        [JsonProperty("type")]
        public string Action { get; set; }
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
        [JsonProperty("primaryId")]
        public int UserId { get; set; }
        [JsonProperty("icon")]
        public string IconUrl { get; set; }

        public Event(string status, string subName, string action, int timestamp, int votes, int comments, string link, string title, string author, int uid, int primaryId, string iconUrl)
        {
            Status = status;
            SubName = subName;
            Action = action;
            Timestamp = timestamp;
            Votes = votes;
            Comments = comments;
            Link = link;
            Title = title;
            Author = author;
            Uid = uid;
            PrimaryId = primaryId;
            IconUrl = iconUrl;
        }
    }
}
