using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using FireScan.Database;
using Newtonsoft.Json;

namespace FireScan
{
    class Program
    {

        public const string Url = @"https://www.meneame.net/backend/sneaker2";

        static void Main(string[] args)
        {
            string path;
            if (args.Length == 0)
            {
                path = "output.txt";
                Console.WriteLine($"Output path was not specified, file will be save in {Path.GetFullPath(path)}");
            }
            else
            {
                path = args[0];
            }

            var autoEvent = new AutoResetEvent(false);
            var io = new FireScanIO();
            WebScanner scanner = new WebScanner(Url);

            Timer timer = new Timer(async state =>
            {
                Console.WriteLine($"Downloading data from {Url}");
                string json = await scanner.DownloadData();
                WebData webData = JsonConvert.DeserializeObject<WebData>(json);
                io.AddEventsToDatabase(webData.Events);

                string[] lines = FireScanIO.WebDataToLines(webData);
                File.AppendAllLines(path, lines);
                Console.WriteLine($"Log was saved in {path}");
            }, autoEvent, 250, 10000);
            autoEvent.WaitOne();
        }
    }
}
