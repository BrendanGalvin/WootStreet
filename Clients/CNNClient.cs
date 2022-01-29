
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
    public class CNNClient : IDisposable
    {
        private readonly HttpClient http;
        public CNNClient()
        {
            this.http = new HttpClient
            {
                BaseAddress = new Uri("http://rss.cnn.com/rss/")
            };
        }

        ~CNNClient()
        {
            this.Dispose(false);
        }



        public async Task<List<string>> GetUSHeadlines()
        {
            var url = "cnn_us.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public async Task<List<string>> GetTopHeadlines()
        {
            var url = "cnn_topstories.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetEntertainmentHeadlines()
        {
            var url = "cnn_showbiz.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetHealthHeadlines()
        {
            var url = "cnn_health.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetUnderscoredHeadlines()
        {
            var url = "cnn-underscored";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public async Task<List<string>> GetLatestHeadlines()
        {
            var url = "cnn_latest.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetTravelHeadlines()
        {
            var url = "cnn_travel.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetWorldHeadlines()
        {
            var url = "cnn_world.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
                    headlines.RemoveAt(0);
                return headlines;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




        public async Task<List<string>> GetPoliticsHeadlines()
        {
            var url = "cnn_allpolitics.rss";

            try
            {
                var stream = await this.http.GetAsync(url);
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
                if (headlines[0].Contains("CNN.com"))
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
