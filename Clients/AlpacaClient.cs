using Alpaca.Markets;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootStreet.Clients
{
    public class AlpacaClient : IDisposable
    {
        private static string API_KEY = Global.AlpacaKey;
        private static string API_SECRET = Global.AlpacaSecret;


        public AlpacaClient()
        {

        }

        ~AlpacaClient()
        {
            this.Dispose(false);
        }



        public async Task<IPage<IBar>> GetData(string ticker)
        {
            var client = Environments.Paper
                   .GetAlpacaDataClient(new SecretKey(API_KEY, API_SECRET));

            
            var bars = await client.ListHistoricalBarsAsync(
              new HistoricalBarsRequest(ticker, DateTime.Today.AddDays(-30), DateTime.Today, BarTimeFrame.Day));

            return bars;
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
            }
        }
    }
}
