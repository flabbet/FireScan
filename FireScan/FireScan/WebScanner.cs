using System.Net.Http;
using System.Threading.Tasks;

namespace FireScan
{
    public class WebScanner
    {
        public string Url { get; set; }

        public WebScanner(string url)
        {
            Url = url;
        }

        public async Task<string> DownloadData(string requestParameters = "")
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync(Url + requestParameters);
        }
    }
}
