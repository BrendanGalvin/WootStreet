
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;
using WootStreet.Models;
using Newtonsoft.Json;
using System.Text;

namespace WootStreet.Clients
{
    public class TheOnionClient : IDisposable
    {
        private readonly HttpClient http;
        public TheOnionClient()
        {
            this.http = new HttpClient
            {
                BaseAddress = new Uri("https://www.theonion.com/rss")
            };
        }

        ~TheOnionClient()
        {
            this.Dispose(false);
        }



        public async Task<List<string>> GetHeadlines()
        {
            try
            {
                var stream = await this.http.GetAsync("");
                string streamContent = await stream.Content.ReadAsStringAsync();
                List<string> headlines = new List<string>();
                while (streamContent.Contains("<title><![CDATA["))
                {
                    var startTag = "<title><![CDATA[";
                    int startIndex = streamContent.IndexOf(startTag) + startTag.Length;
                    int endIndex = streamContent.IndexOf("]]></title>", startIndex);
                    headlines.Add(streamContent.Substring(startIndex, endIndex - startIndex));
                    streamContent = streamContent.Substring(endIndex);
                }
                if (headlines[0].Contains("America's Finest News"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool freeManagedObjects)
        {
            if (freeManagedObjects)
            {
                if (this.http != null)
                {
                    this.http.Dispose();
                }
            }
        }

    }
}