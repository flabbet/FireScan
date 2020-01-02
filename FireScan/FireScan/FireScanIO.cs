using System;
using System.Collections.Generic;
using System.Text;

namespace FireScan
{
    public class FireScanIO
    {
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
