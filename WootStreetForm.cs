using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WootStreet.Services;
using WootStreet.Clients;

namespace WootStreet
{
    public partial class WootStreetForm : Form
    {
        CNNClient cnnReader = new CNNClient();
        TheOnionClient onionReader = new TheOnionClient();
        CNNMoneyClient dow = new CNNMoneyClient();
        TwitterClient twitter = new TwitterClient();
        AlpacaClient alpaca = new AlpacaClient();
        int countdownUntilNextChart = 0;

        public WootStreetForm()
        {
            InitializeComponent();
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            string ticker = Global.cashTags[new Random().Next(Global.cashTags.Count)];
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                ticker = textBox2.Text;
            var message = await MessageBuilder.HeadlineMessage(cnnReader, dow, onionReader, ticker);
            string TAphrase = Global.TAPhrases[new Random().Next(Global.TAPhrases.Count)];
            await Charting.renderDataToChart(chart1, ticker, alpaca);
            var secondTweetID = await twitter.PostTweetWithMedia(message, chart1);
            PostHeadlineToDiscord(secondTweetID.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            headlineTimer.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            headlineTimer.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void headlineTimer_Tick(object sender, EventArgs e)
        {

            TimeSpan start = new TimeSpan(6, 30, 15); //6:30 AM, but delayed slightly to make sure wobsites are working properly with market open
            TimeSpan end = new TimeSpan(13, 0, 0); //1 PM
            TimeSpan now = DateTime.Now.TimeOfDay;
            if ((now > start) && (now < end))
            {
                countdownUntilNextChart++;
                string ticker = Global.cashTags[new Random().Next(Global.cashTags.Count)];
                var message = await MessageBuilder.HeadlineMessage(cnnReader, dow, onionReader, ticker);
                string TAphrase = Global.TAPhrases[new Random().Next(Global.TAPhrases.Count)];
                await Charting.renderDataToChart(chart1, ticker, alpaca);
                var secondTweetID = await twitter.PostTweetWithMedia(message, chart1);
                PostHeadlineToDiscord(secondTweetID.ToString());
                countdownUntilNextChart = 0;

            }
        }


        private async void PostHeadlineToDiscord(string message)
        {

            if (await dow.IsDowUp())
            {
                await Discord.PostDiscord("https://twitter.com/OptionusP/status/" + message); //https://cdn.discordapp.com/attachments/700386029986906116/718321864333852782/image0.gif
            }
            else
            {
                await Discord.PostDiscord("https://twitter.com/OptionusP/status/" + message); //https://cdn.discordapp.com/attachments/700386029986906116/718322723587358730/image0.gif
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            twitter.SetPIN(textBox1.Text);
        }

    }
}