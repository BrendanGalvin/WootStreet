using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;

namespace WootStreet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("Keys.json", optional: false)
            .Build();
            Global.AlpacaKey = configuration["AlpacaKey"];
            Global.AlpacaSecret = configuration["AlpacaSecret"];
            Global.TwitterKey = configuration["TwitterKey"];
            Global.TwitterSecret = configuration["TwitterSecret"];
            Global.DiscordWebhookURL = configuration["DiscordWebhookURL"];
            Global.DiscordUsername = configuration["DiscordUsername"];
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WootStreetForm());
        }
    }
}
