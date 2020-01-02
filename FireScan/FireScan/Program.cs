using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FireScan
{
    class Program
    {

        public const string Url = @"https://www.meneame.net/backend/sneaker2";

        static async Task Main(string[] args)
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
            WebScanner scanner = new WebScanner(Url);
            Console.WriteLine($"Downloading data from {Url}");
            string json = await scanner.DownloadData();
            WebData webData = JsonConvert.DeserializeObject<WebData>(json);

            string[] lines = FireScanIO.WebDataToLines(webData);
            File.WriteAllLines(path, lines);
            Console.WriteLine($"Log was saved in {path}");
        }
    }
}
