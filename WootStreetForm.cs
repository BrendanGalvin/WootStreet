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

        public WootStreetForm()
        {
            InitializeComponent();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await Posting.PostMessageToMedia(chart1, textBox2.Text);
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
            
            TimeSpan start = new TimeSpan(14, 30, 5); //2:30 PM UTC, when markets open, but delayed slightly to make sure wobsites are working properly with market open.
            TimeSpan end = new TimeSpan(21, 0, 0); //9 PM UTC, markets closed.
            TimeSpan now = DateTime.UtcNow.TimeOfDay; //Get the current time of day in UTC timezone, to normalize across regions (but I'm sure there's some garbage with stuff like Daylight Savings or who knows what else)
            if ((now > start) && (now < end))
            {
                await Posting.PostMessageToMedia(chart1);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Global.Twitter.SetPIN(textBox1.Text);
        }

        private void TwitterCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            Global.PostToTwitter = TwitterCheckbox.Checked;
        }

        private void DiscordCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            Global.PostToDiscord = DiscordCheckbox.Checked;
        }
    }
}