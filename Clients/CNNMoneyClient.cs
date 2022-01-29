
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;
using WootStreet.Models;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace WootStreet.Clients
{
    public class CNNMoneyClient : IDisposable
    {
        private readonly HttpClient http;
        public CNNMoneyClient()
        {
            this.http = new HttpClient
            {
                BaseAddress = new Uri("https://money.cnn.com/")
            };
        }

        ~CNNMoneyClient()
        {
            this.Dispose(false);
        }



        public async Task<bool> IsDowUp()
        {
            var url = "data/markets/";

            try
            {
                var stream = await this.http.GetAsync(url);
                string streamContent = await stream.Content.ReadAsStringAsync();
                
                if (streamContent.Contains("data-ticker-name=\"Dow\"><span class=\"negData\">"))
                    return false;
                return true;

                var startTag = "<meta name=\"priceChange\" content=\"";
                int startIndex = streamContent.IndexOf(startTag) + startTag.Length;
                int endIndex = streamContent.IndexOf("\">", startIndex);
                var result = streamContent.Substring(startIndex, endIndex - startIndex);
                MessageBox.Show(JsonConvert.SerializeObject(streamContent, Formatting.Indented));
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(JsonConvert.SerializeObject(e, Formatting.Indented));
                return false;
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
