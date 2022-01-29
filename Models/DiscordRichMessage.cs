using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WootStreet.Models
{
    public class DiscordRichMessage
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string content;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? tts;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DiscordEmbed[] embeds;
    }
}
