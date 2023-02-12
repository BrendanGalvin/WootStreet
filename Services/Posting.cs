using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using WootStreet.Clients;

namespace WootStreet.Services
{
    public static class Posting
    {

        public static async Task<string> BuildHeadlineMessage(CNNClient cnnReader, CNNMoneyClient dow, TheOnionClient onionReader, string ticker)
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

        /// <summary>
        /// Given the chart UI element, and an optional ticker, this will create a brand new social media post and post it to the user-selected channels.
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="ticker"></param>
        /// <returns></returns>
        public static async Task PostMessageToMedia(Chart chart, string ticker = "")
        {
            if (string.IsNullOrEmpty(ticker))
            {
                ticker = Global.cashTags[new Random().Next(Global.cashTags.Count)]; // Pick at random.
            }
            var message = await Posting.BuildHeadlineMessage(Global.CNNReader, Global.Dow, Global.OnionReader, ticker);
            string TAphrase = Global.TAPhrases[new Random().Next(Global.TAPhrases.Count)];
            bool resultOfChart = await Charting.renderDataToChart(chart, ticker, Global.Alpaca);
            if (!resultOfChart)
                return;
            long tweetID = 0;
            if (Global.PostToTwitter)
            {
                tweetID = await Global.Twitter.PostTweetWithMedia(message, chart);
            }
            if (Global.PostToDiscord)
            {
                if (tweetID == 0)
                {
                    await PostMessageToDiscord(message);
                }
                else
                {
                    await PostTweetToDiscord(Global.TwitterHandle, tweetID.ToString());
                }
            }
        }

        /// <summary>
        /// Posts a simple text message to Discord.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static async Task PostMessageToDiscord(string message)
        {
            await Discord.PostDiscord(message);
        }

        /// <summary>
        /// Posts a tweet to Discord.
        /// </summary>
        /// <param name="twitterHandle"></param>
        /// <param name="messageID"></param>
        /// <returns></returns>
        public static async Task PostTweetToDiscord(string twitterHandle, string messageID)
        {
            await Discord.PostDiscord("https://twitter.com/" + twitterHandle + "/status/" + messageID);
        }


    }
}
