using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Alpaca.Markets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Newtonsoft.Json;
using WootStreet.Clients;

namespace WootStreet.Services
{
    public static class Charting
    {
        
        /// <summary>
        /// Given a Chart object, returns a byte array representing a bitmap screenshot of the control.
        /// </summary>
        public static byte[] screenshotByteArray(Chart chart)
        {
            Bitmap bp = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bp, new Rectangle(0, 0, chart.Width, chart.Height));
            MemoryStream stream = new MemoryStream();
            bp.Save(stream, ImageFormat.Bmp);
            return stream.ToArray();
        }


        public async static Task renderDataToChart(Chart chart, string ticker, AlpacaClient alpaca)
        {
            try
            {
                chart.Series.Clear();
                chart.Series.Add("$" + ticker);
                chart.Series.Add("Band Upper Bound");
                chart.Series.Add("Trend");
                chart.Series.Add("Band Lower Bound");
                chart.Series.Add("Resistance");
                chart.Series["$" + ticker].XValueType = ChartValueType.DateTime;
                chart.Series["Band Upper Bound"].XValueType = ChartValueType.DateTime;
                chart.Series["Trend"].XValueType = ChartValueType.DateTime;
                chart.Series["Band Lower Bound"].XValueType = ChartValueType.DateTime;
                chart.Series["Resistance"].XValueType = ChartValueType.DateTime;
                var bars = await alpaca.GetData(ticker);
                var minValue = bars.Items.First();
                var absoluteMinValue = bars.Items.First();
                var maxValue = bars.Items.First();
                var absoluteMaxValue = bars.Items.First();
                int i = 0;
                foreach (IBar bar in bars.Items)
                {
                    i++;
                    if (bar.Close < minValue.Close && i < bars.Items.Count - 3)
                        minValue = bar;
                    if (bar.Close < absoluteMinValue.Close)
                        absoluteMinValue = bar;
                    if (bar.Close > maxValue.Close && i < bars.Items.Count - 3)
                        maxValue = bar;
                    if (bar.Close > absoluteMaxValue.Close)
                        absoluteMaxValue = bar;

                    chart.Series["$" + ticker].Points.AddXY(bar.TimeUtc, bar.Close);
                }
                chart.Series["$" + ticker].BorderWidth = 2;
                chart.Series["$" + ticker].Color = Color.Red;
                chart.Series["$" + ticker].ChartType = SeriesChartType.Line;
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 4;
                chart.ChartAreas["ChartArea1"].AxisY.Interval = (double)((absoluteMaxValue.Close - absoluteMinValue.Close) / 5);
                chart.ChartAreas["ChartArea1"].AxisY.Minimum = (double)(absoluteMinValue.Close * 0.92M);
                chart.ChartAreas["ChartArea1"].AxisY.Maximum = (double)(absoluteMaxValue.Close * 1.08M);
                chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gray;
                chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gray;
                decimal rand = new Random().Next(2, 5);
                rand /= 100;
                rand += 1;
                chart.Series["Band Upper Bound"].Points.AddXY(maxValue.TimeUtc, maxValue.Close);
                chart.Series["Band Upper Bound"].Points.AddXY(bars.Items[bars.Items.Count - 1].TimeUtc, bars.Items[bars.Items.Count - 1].Close * rand);

                chart.Series["Band Upper Bound"].BorderWidth = 2;
                chart.Series["Band Upper Bound"].Color = Color.Blue;
                chart.Series["Band Upper Bound"].ChartType = SeriesChartType.Line;



                chart.Series["Band Lower Bound"].Points.AddXY(minValue.TimeUtc, minValue.Close);
                chart.Series["Band Lower Bound"].Points.AddXY(bars.Items[bars.Items.Count - 1].TimeUtc, bars.Items[bars.Items.Count - 1].Close / rand);

                chart.Series["Band Lower Bound"].BorderWidth = 2;
                chart.Series["Band Lower Bound"].Color = Color.Blue;
                chart.Series["Band Lower Bound"].ChartType = SeriesChartType.Line;

                chart.Series["Trend"].Points.AddXY(bars.Items[0].TimeUtc, bars.Items[0].Close);
                chart.Series["Trend"].Points.AddXY(bars.Items[bars.Items.Count - 1].TimeUtc, bars.Items[bars.Items.Count - 1].Close);

                chart.Series["Trend"].BorderWidth = 2;
                chart.Series["Trend"].Color = Color.Brown;
                chart.Series["Trend"].ChartType = SeriesChartType.Line;
                chart.Series["Resistance"].Points.AddXY(bars.Items[0].TimeUtc, absoluteMinValue.Close);
                chart.Series["Resistance"].Points.AddXY(DateTime.Now, absoluteMinValue.Close);
                chart.Series["Resistance"].BorderWidth = 2;
                chart.Series["Resistance"].Color = Color.Purple;
                chart.Series["Resistance"].ChartType = SeriesChartType.Line;
                chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "0.00";
            }
            catch(Exception e)
            {
                MessageBox.Show(JsonConvert.SerializeObject(e, Formatting.Indented));
            }
        }
    }
}
