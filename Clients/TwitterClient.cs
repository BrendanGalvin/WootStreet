using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using CoreTweet;
using WootStreet.Services;

namespace WootStreet.Clients
{
    public class TwitterClient
    {
        private OAuth.OAuthSession session;
        private Tokens tokens;
        public TwitterClient()
        {
            this.session = OAuth.Authorize(Global.TwitterKey, Global.TwitterSecret, "oob");
            System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
        }

        public void SetPIN(string pincode)
        {
            this.tokens = session.GetTokens(pincode);
        }
        public async Task<long> PostTweet(string content)
        {
            await this.tokens.Statuses.UpdateAsync(status => content);
            return (await this.tokens.Statuses.UserTimelineAsync())[0].Id;
        }

        public async Task<long> PostTweetWithMedia(string content, Chart chart)
        {
            var result = await this.tokens.Media.UploadAsync(Charting.screenshotByteArray(chart));
            await this.tokens.Statuses.UpdateAsync(new { status = content, media_ids = result.MediaId });
            return (await this.tokens.Statuses.UserTimelineAsync())[0].Id;
        }
    }
}
