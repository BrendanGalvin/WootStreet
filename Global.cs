﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WootStreet.Clients;

namespace WootStreet
{
    public static class Global
    {
        public static CNNClient CNNReader;
        public static TheOnionClient OnionReader;
        public static CNNMoneyClient Dow;
        public static TwitterClient Twitter;
        public static AlpacaClient Alpaca;
        public static string TwitterKey { get; set; }
        public static string TwitterSecret { get; set; }
        public static string DiscordWebhookURL { get; set; }
        public static string AlpacaKey { get; set; }
        public static string AlpacaSecret { get; set; }
        public static string DiscordUsername { get; set; }
        public static string TwitterHandle { get; set; }
        public static bool PostToTwitter { get; set; } = true;
        public static bool PostToDiscord { get; set; } = true;

        public static List<string> RisingHeadlines = new List<string>
        {
            "climbs",
            "soars",
            "apexed",
            "started rising",
            "bullish",
            "shoots up",
            "rockets to the moon",
            "peaked",
            "rises",
            "escalates",
            "trends upward",
            "breaks out",
            "goes ballistic",
            "throws a party",
            "practices the art of 'being very high'",
            "took viagra",
            "hopped on a SpaceX rocket",
            "blew itself harder than a Russian tank",
            "headed to the sky faster than an F-22 tracking a Chinese balloon"
        };

        public static List<string> FallingHeadline = new List<string>
        {
            "plummets",
            "sinks",
            "plunges",
            "started falling",
            "bearish",
            "drops",
            "tumbles",
            "hits rock-bottom",
            "trends downward",
            "crumbles",
            "implodes",
            "dies down",
            "breaks down",
            "huddles in a corner to cry",
            "slaps itself for being ugly"
        };

        public static List<string> Speed = new List<string>
        {
            "quickly",
            "sluggishly",
            "sluggardly",
            "rapidly",
            "briskly",
            "promptly",
            "gently",
            "comfortably",
            "leisurely",
            "speedily",
            "slowly",
            "abruptly",
            "suddenly",
            "slothfully",
            "immediately",
            "tenderly",
            "unexpectedly",
            "catastrophically",
            "impressively",
            "hastily",
            "quicker than an F-22 tracking a Chinese balloon"
        };

        public static List<string> PublishPhrases = new List<string>
        {
            "News media publishes",
            "Newspapers write",
            "Reported by news crews around the globe",
            "Hack reporters at major news publisher write",
            "Genius reporters at Newspaper Incorporated write",
            "Trump's favorite establishment, News Inc, writes",
            "News puff-piece is titled",
            "Latest headlines",
            "Latest news",
            "Breaking news",
            "Currently happening",
            "Autobot spies report",
            "Informants in Megatron's ranks tell us",
            "Cybertron News Network reports",
            "My uncle told me",
            "Some hobo on the street let me in on a secret. He said",
            "Hunter Biden's Laptop has documents relating to",
            "Donald Trump admitted to",
            "Hillary's Emails are alleged to contain data relating to",
            "A little bird-bot told me",
            "Someone on Reddit said",
            "I heard on Discord"
        };

        public static List<string> RisingPhrases = new List<string>
        {
            "This is surely the reason for my meteoric success today! ROLL OUT!",
            "This is why the Dow is up today!",
            "I think this is why the Dow is up right now.",
            "This seems like good DD.",
            "I will be paying close attention to this.",
            "Megatron doesn't stand a chance against this market! OR ME!",
            "This is why Earth is so much better than Cybertron!",
            "Profits are essential to our freedoms!",
            "Dividends are the right of all sentient beings!",
            "Autobots cannot be defeated by the pathetic, poor machinations of Megatron!",
            "Freedom = money!",
            "Cry harder, bears!",
            "Defeat the bears!",
            "NEVER SELL!",
            "HODL!"
        };

        public static List<string> FallingPhrases = new List<string>
        {
            "This is surely the work of the corrupt media and the Decepticons!!",
            "I bet the Russians - and Megatron - are behind this!!",
            "Sad!!!",
            "The autobots do not negotiate with bear markets!",
            "Maybe Earth was a mistake.",
            "I am officially moving my autobots off of Earth, at this horrible news that has caused my net-worth to plummet.",
            "We must not fall victim to Megatron's machinations.",
            "CNN is at fault somehow, I know it!",
            "NOOOOOOOO!!!",
            "Buy high, sell low!",
            "An excellent opportunity for shorting!",
            "Sell naked calls!",
            "My put debit spread is doing well!",
            "SELL EVERYTHING!!",
            "Be greedy when others are fearful!",
            "Cash is trash! Or so I've been told."
        };


        public static List<string> cashTags = new List<string>
        {
            "MMM",
"AOS",
"ABT",
"ABBV",
"ABMD",
"ACN",
"ATVI",
"ADBE",
"AAP",
"AMD",
"AES",
"AFL",
"A",
"APD",
"AKAM",
"ALK",
"ARE",
"ALB",
"ALXN",
"ALGN",
"ALLE",
"ADS",
"LNT",
"ALL",
"GOOGL",
"GOOG",
"MO",
"AMZN",
"AMCR",
"AEE",
"AAL",
"AEP",
"AXP",
"AIG",
"AMT",
"AWK",
"AMP",
"ABC",
"AME",
"AMGN",
"APH",
"ADI",
"ANSS",
"ANTM",
"AON",
"APA",
"AIV",
"AAPL",
"AMAT",
"APTV",
"ADM",
"ANET",
"AJG",
"AIZ",
"T",
"ATO",
"ADSK",
"ADP",
"AZO",
"AVB",
"AVY",
"BKR",
"BLL",
"BAC",
"BAX",
"BDX",
"BRK.B",
"BBY",
"BIIB",
"BLK",
"BA",
"BKNG",
"BWA",
"BXP",
"BSX",
"BMY",
"AVGO",
"BR",
"BF.B",
"CHRW",
"COG",
"CDNS",
"CPB",
"COF",
"CAH",
"KMX",
"CCL",
"CARR",
"CAT",
"CBOE",
"CBRE",
"CDW",
"CE",
"CNC",
"CNP",
"CTL",
"CERN",
"CF",
"SCHW",
"CHTR",
"CVX",
"CMG",
"CB",
"CHD",
"CI",
"CINF",
"CTAS",
"CSCO",
"C",
"CFG",
"CTXS",
"CME",
"CMS",
"KO",
"CTSH",
"CL",
"CMCSA",
"CMA",
"CAG",
"CXO",
"COP",
"ED",
"STZ",
"CPRT",
"GLW",
"CTVA",
"COST",
"COTY",
"CCI",
"CSX",
"CMI",
"CVS",
"DHI",
"DHR",
"DRI",
"DVA",
"DE",
"DAL",
"XRAY",
"DVN",
"DXCM",
"FANG",
"DLR",
"DFS",
"DISCA",
"DISCK",
"DISH",
"DG",
"DLTR",
"D",
"DPZ",
"DOV",
"DOW",
"DTE",
"DUK",
"DRE",
"DD",
"DXC",
"ETFC",
"EMN",
"ETN",
"EBAY",
"ECL",
"EIX",
"EW",
"EA",
"EMR",
"ETR",
"EOG",
"EFX",
"EQIX",
"EQR",
"ESS",
"EL",
"RE",
"EVRG",
"ES",
"EXC",
"EXPE",
"EXPD",
"EXR",
"XOM",
"FFIV",
"FB",
"FAST",
"FRT",
"FDX",
"FIS",
"FITB",
"FRC",
"FE",
"FISV",
"FLT",
"FLIR",
"FLS",
"FMC",
"F",
"FTNT",
"FTV",
"FBHS",
"FOXA",
"FOX",
"BEN",
"FCX",
"GPS",
"GRMN",
"IT",
"GD",
"GE",
"GIS",
"GM",
"GPC",
"GILD",
"GPN",
"GL",
"GS",
"GWW",
"HRB",
"HAL",
"HBI",
"HOG",
"HIG",
"HAS",
"HCA",
"PEAK",
"HSIC",
"HES",
"HPE",
"HLT",
"HFC",
"HOLX",
"HD",
"HON",
"HRL",
"HST",
"HWM",
"HPQ",
"HUM",
"HBAN",
"HII",
"IEX",
"IDXX",
"INFO",
"ITW",
"ILMN",
"INCY",
"IR",
"INTC",
"ICE",
"IBM",
"IP",
"IPG",
"IFF",
"INTU",
"ISRG",
"IVZ",
"IPGP",
"IQV",
"IRM",
"JBHT",
"JKHY",
"J",
"SJM",
"JNJ",
"JCI",
"JPM",
"JNPR",
"KSU",
"K",
"KEY",
"KEYS",
"KMB",
"KIM",
"KMI",
"KLAC",
"KSS",
"KHC",
"KR",
"LB",
"LHX",
"LH",
"LRCX",
"LW",
"LVS",
"LEG",
"LDOS",
"LEN",
"LLY",
"LNC",
"LIN",
"LYV",
"LKQ",
"LMT",
"L",
"LOW",
"LYB",
"MTB",
"MRO",
"MPC",
"MKTX",
"MAR",
"MMC",
"MLM",
"MAS",
"MA",
"MXIM",
"MKC",
"MCD",
"MCK",
"MDT",
"MRK",
"MET",
"MTD",
"MGM",
"MCHP",
"MU",
"MSFT",
"MAA",
"MHK",
"TAP",
"MDLZ",
"MNST",
"MCO",
"MS",
"MSI",
"MSCI",
"MYL",
"NDAQ",
"NOV",
"NTAP",
"NFLX",
"NWL",
"NEM",
"NWSA",
"NWS",
"NEE",
"NLSN",
"NKE",
"NI",
"NBL",
"JWN",
"NSC",
"NTRS",
"NOC",
"NLOK",
"NCLH",
"NRG",
"NUE",
"NVDA",
"NVR",
"ORLY",
"OXY",
"ODFL",
"OMC",
"OKE",
"ORCL",
"OTIS",
"PCAR",
"PKG",
"PH",
"PAYX",
"PAYC",
"PYPL",
"PNR",
"PBCT",
"PEP",
"PKI",
"PRGO",
"PFE",
"PM",
"PSX",
"PNW",
"PXD",
"PNC",
"PPG",
"PPL",
"PFG",
"PG",
"PGR",
"PLD",
"PRU",
"PEG",
"PSA",
"PHM",
"PVH",
"QRVO",
"QCOM",
"PWR",
"DGX",
"RL",
"RJF",
"RTX",
"O",
"REG",
"REGN",
"RF",
"RSG",
"RMD",
"RHI",
"ROK",
"ROL",
"ROP",
"ROST",
"RCL",
"SPGI",
"CRM",
"SBAC",
"SLB",
"STX",
"SEE",
"SRE",
"NOW",
"SHW",
"SPG",
"SWKS",
"SLG",
"SNA",
"SO",
"LUV",
"SWK",
"SBUX",
"STT",
"STE",
"SYK",
"SIVB",
"SYF",
"SNPS",
"SYY",
"TMUS",
"TROW",
"TTWO",
"TPR",
"TGT",
"TEL",
"FTI",
"TFX",
"TXN",
"TXT",
"BK",
"CLX",
"COO",
"HSY",
"MOS",
"TRV",
"DIS",
"TMO",
"TIF",
"TJX",
"TSCO",
"TT",
"TDG",
"TFC",
"TWTR",
"TSN",
"USB",
"UDR",
"ULTA",
"UAA",
"UA",
"UNP",
"UAL",
"UNH",
"UPS",
"URI",
"UHS",
"UNM",
"VFC",
"VLO",
"VAR",
"VTR",
"VRSN",
"VRSK",
"VZ",
"VRTX",
"VIAC",
"V",
"VNO",
"VMC",
"WRB",
"WAB",
"WBA",
"WMT",
"WM",
"WAT",
"WEC",
"WFC",
"WELL",
"WST",
"WDC",
"WU",
"WRK",
"WY",
"WHR",
"WMB",
"WLTW",
"WYNN",
"XEL",
"XRX",
"XLNX",
"XYL",
"YUM",
"ZBRA",
"ZBH",
"ZION",
"ZTS",
            "USO",
            "SPY",
            "LK",
            "HTZ",
            "TSLA",
            "QQQ",
            "VIX",
            "NIO",
            "XOM",
            "SPCE",
            "AMZN",
            "ZM",
            "MRNA",
            "BP",
            "GOOGL",
            "NKLA"
        };

        public static List<string> TAPhrases = new List<string>
        {
            "Autobots have superior charting capabilities. We have devised this chart to provide our Earth friends with increased financial expertise.",
            "The implications are clear.",
            "The Decepticons won't know what hit them when we utilize this secret and forbidden Technical Analysis to steal their dollars.",
            "Wall Street, we're coming for you.",
            "If you don't know what these lines mean, are you even really trading?",
            "I think the obvious move is clear.",
            "Autotraders, roll out!",
            "Our superior processing capability gives us Autobots a clear advantage over the humans. We must share this power with them.",
            "The AllSpark gave Autobots the capability to make independent financial decisions, and we share that power now with you, humans.",
            "Before time began, there was profit. And the Cube. But mostly profit.",
            "We know not where charts come from, only that they hold the power to create dollars.",
            "Humans seem to delight in the delicacy known as \"chicken tenders.\" With this financial analysis, the tenders - or 'tendies' as they are sometimes known - will flow.",
            "The nature of this complex and intricate mathematical analysis of price charts is known only to a few. We share this knowledge with you, human!",
            "Successful traders draw lines on charts.",
            "If you aren't drawing lines on charts, you are a decepticon.",
            "Only those who know the secret of the lines, can truly discern the seccrets to infinite profit.",
            "I heard Jim Cramer likes my methods. I do not know who this Jim is, but he is most welcome to view my charts.",
            "He who controls the profits, controls the universe.",
            "A hive of scum and villainy - and profits!"
        };

    }
}