using System.Windows.Forms.DataVisualization.Charting;

namespace TicketSeller.Views.Munkaképernyő.Statistics
{
    public abstract class DashboardModel
    {
        public string Name { get; set; }
        public bool IsSuccessfuly { get; set; }
        public string Message { get; set; }

        public abstract void Load(ref Chart chart);
    }
    public class TicketStatistics : DashboardModel
    {
        public Dictionary<string, int> Items { get; set; }


        public TicketStatistics()
        {

            Items = new Dictionary<string, int>();
        }

        public override void Load(ref Chart chart)
        {
            if (chart.Series.Count > 0)
            {
                chart.Series[0].Points.Clear();
                chart.Series.Clear();
            }


            Series series = new Series();

            series.ChartType = SeriesChartType.Pie;
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = "vl";
            series.YValuesPerPoint = 2;
            decimal sum = Items.Sum(d => d.Value);

            foreach (var item in Items)
            {
                decimal val = (decimal)item.Value;
                DataPoint dataPoint = new DataPoint(0D, (double)val);
                dataPoint.LegendText = item.Key;
                dataPoint.IsValueShownAsLabel = false;
                decimal percentage = Math.Round((100 * val) / sum, 0);
                dataPoint.Label = $"{percentage.ToString()}%";

                series.Points.Add(dataPoint);
            }

            chart.Series.Add(series);

        }
    }
    public class MoneyStatistics : DashboardModel
    {
        public Dictionary<DateTime, int> Items { get; set; }

        public MoneyStatistics()
        {
            Items = new Dictionary<DateTime, int>();
        }

        public override void Load(ref Chart chart)
        {
            if (chart.Series.Count > 0)
            {
                chart.Series[0].Points.Clear();
                chart.Series.Clear();
            }

            Series series = new Series();
            series.BackHatchStyle = ChartHatchStyle.BackwardDiagonal;
            series.ChartType = SeriesChartType.Bar;
            series.ChartArea = "ChartArea1";
            series.Legend = "Legend1";
            series.Name = "Össz bevétel heti lebontásban";
            series.YValuesPerPoint = 2;
            chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;

            foreach (var item in Items)
            {
                double val = (double)item.Value;
                DataPoint dataPoint = new DataPoint(0D, val);
                dataPoint.Label = item.Key.ToShortDateString();

                series.Points.Add(dataPoint);
            }

            chart.Series.Add(series);
        }
    }
}
