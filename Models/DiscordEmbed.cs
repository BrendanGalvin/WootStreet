using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WootStreet.Models
{
    public class DiscordEmbed
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string title;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string description;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string url;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? color;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DiscordEmbedImage image;
    }
}
