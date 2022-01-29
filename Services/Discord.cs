using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using WootStreet.Models;
using System.Text.RegularExpressions;

namespace WootStreet.Services
{
    public static class Discord
    {

        private static readonly HttpClient http = new HttpClient
        {
            BaseAddress = new Uri("https://discordapp.com/api/webhooks/")
        };

        public static async Task<string> PostDiscord(string message)
        {

            try
            {

                var values = new DiscordMessage();
                values.username = Global.DiscordUsername;
                values.avatar_url = "";
                //message = Regex.Replace(message, @"\.(\d)(\d)(\d*)", ".$1$2");

                values.content = message;

                var stream = await http.PostAsync(Global.DiscordWebhookURL, new StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json"));
                string streamContent = await stream.Content.ReadAsStringAsync();
                return streamContent;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static async Task<string> PostDiscordEmbed(string content, string imageURL, string title)
        {

            try
            {
                DiscordEmbed[] embed = new DiscordEmbed[1];
                embed[0] = new DiscordEmbed();
                DiscordEmbedImage image = new DiscordEmbedImage();
                DiscordRichMessage embeddedMessage = new DiscordRichMessage();
                image.url = imageURL;
                embed[0].title = title;
                embed[0].image = image;
                //content = Regex.Replace(content, @"\.(\d)(\d)(\d*)", ".$1$2");
                embed[0].description = content;
                embed[0].color = 8900331;
                embeddedMessage.embeds = embed;
                var stream = await http.PostAsync(Global.DiscordWebhookURL, new StringContent(JsonConvert.SerializeObject(embeddedMessage), Encoding.UTF8, "application/json"));
                string streamContent = await stream.Content.ReadAsStringAsync();
                return streamContent;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
