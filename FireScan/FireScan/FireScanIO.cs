using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireScan.Database;

namespace FireScan
{
    public class FireScanIO
    {
        private SqLiteDbContext _db = new SqLiteDbContext();


        public FireScanIO()
        {
            _db.Database.EnsureCreated();
        }

        public void AddEventsToDatabase(List<Event> events)
        {
            foreach (var @event in events)
            {
                if (_db.Events.Count(x => x.Title == @event.Title) > 0)
                {
                    _db.Events.First(x => x.Title == @event.Title).Comments = @event.Comments;
                    _db.Events.First(x => x.Title == @event.Title).Votes = @event.Votes;
                    Console.WriteLine($"Updated {@event.Action}s in {@event.Title}");
                }
                else
                {
                    Console.WriteLine($"Added post '{@event.Title}' to database.");
                    _db.Events.Add(@event);
                    _db.SaveChanges();
                }
            }
        }

        public static string[] WebDataToLines(WebData webData)
        {
            List<string> lines = new List<string>();
            foreach (var webDataEvent in webData.Events)
            {
                lines.Add($"Timestamp: {webDataEvent.Timestamp}: Sub: {webDataEvent.SubName}, Votes: {webDataEvent.Votes}" +
                          $", Comments: {webDataEvent.Comments}, News: {webDataEvent.Title}, Author: {webDataEvent.Author}, " +
                          $"Status: {webDataEvent.Status}");
            }

            return lines.ToArray();
        }
    }
}
