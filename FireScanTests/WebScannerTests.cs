using System;
using System.Threading.Tasks;
using FireScan;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace FireScanTests
{
    public class WebScannerTests
    {
        [Test]
        public async Task TestThatScannerDownloadsJson()
        {
            WebScanner scanner = new WebScanner(@"https://www.meneame.net/backend/sneaker2");
            Assert.IsTrue(IsValidJson(await scanner.DownloadData()));
        }

        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if (strInput.StartsWith("{") && strInput.EndsWith("}") || //For object
                strInput.StartsWith("[") && strInput.EndsWith("]")) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }
    }
}
