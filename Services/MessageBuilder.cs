using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WootStreet.Clients;

namespace WootStreet.Services
{
    public static class MessageBuilder
    {

        public static async Task<string> HeadlineMessage(CNNClient cnnReader, CNNMoneyClient dow, TheOnionClient onionReader, string ticker)
        {
            List<string> headlines = await cnnReader.GetEntertainmentHeadlines();
            headlines.AddRange(await cnnReader.GetHealthHeadlines());
            headlines.AddRange(await onionReader.GetHeadlines());
            string chosenHeadline = headlines[new Random().Next(headlines.Count)];
            string speed = Global.Speed[new Random().Next(Global.Speed.Count)];
            string CNN = Global.PublishPhrases[new Random().Next(Global.PublishPhrases.Count)];

            if (await dow.IsDowUp())
            {
                string movement = Global.RisingHeadlines[new Random().Next(Global.RisingHeadlines.Count)];
                string phrase = Global.RisingPhrases[new Random().Next(Global.RisingPhrases.Count)];
                return ("Dow Jones " + speed + " " + movement + ". " + CNN + ", '" + chosenHeadline + ".' " + phrase + " $" + ticker);
            }
            else
            {
                string movement = Global.FallingHeadline[new Random().Next(Global.FallingHeadline.Count)];
                string phrase = Global.FallingPhrases[new Random().Next(Global.FallingPhrases.Count)];
                return ("Dow Jones " + speed + " " + movement + ". " + CNN + ", '" + chosenHeadline + ".' " + phrase + " $" + ticker);
            }
        }
    }
}
