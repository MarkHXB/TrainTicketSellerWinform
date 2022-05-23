using System.Windows.Forms.DataVisualization.Charting;
using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.TodayFinance;

namespace TicketSeller.Views
{
    public partial class TodayFinanceView : Form, ITodayFinanceView
    {
        private static TodayFinanceView _instance;
        private MoneyAndBankChart mabChart;
        private SumChart sumChart;

        public TodayFinanceView()
        {
            InitializeComponent();

            mabChart = new MoneyAndBankChart();
            sumChart = new SumChart();

            InitializeEvents();
        }

        #region PROPS
        public MoneyAndBankChart MoneyAndBankChart
        {
            get => mabChart;
            set => mabChart = value;
        }
        public SumChart SumChart
        {
            get => sumChart;
            set => sumChart = value;
        }
        #endregion

        #region EVENTS
        public event EventHandler FormLoad;
        public event EventHandler Refresh;
        #endregion

        #region METHODS
        public static TodayFinanceView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new TodayFinanceView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }

        private void InitializeEvents()
        {
            this.Load += delegate
            {
                FormLoad?.Invoke(this, EventArgs.Empty);

                if (mabChart.IsSuccessfullyLoaded)
                {
                    LoadMabChart();
                }
                else MessageBox.Show(mabChart.Message);

                if (sumChart.IsSuccessfullyLoaded)
                {
                    LoadSumChart();
                }
                else MessageBox.Show(sumChart.Message);

                sumPaymentLb.Text = sumChart.SumValue.ToString()+" ft";
            };
            this.updateBtn.Click += delegate 
            { 
                Refresh?.Invoke(this, EventArgs.Empty);

                if (mabChart.IsSuccessfullyLoaded)
                {
                    LoadMabChart();
                }
                else MessageBox.Show(mabChart.Message);

                if (sumChart.IsSuccessfullyLoaded)
                {
                    LoadSumChart();
                }
                else MessageBox.Show(sumChart.Message);

                sumPaymentLb.Text = sumChart.SumValue.ToString() + " ft";
            };
        }

        private void LoadSumChart()
        {
            //sum chart - credit card
            if (chart2.Series.Count > 0)
            {
                chart2.Series[0].Points.Clear();
            }

            DataPoint cdDataPoint = new DataPoint(0D, (double)sumChart.BankValue);
            cdDataPoint.Color = Color.Blue;
            cdDataPoint.LabelForeColor = Color.White;
            cdDataPoint.Font = new Font(FontFamily.GenericSansSerif, 11f, FontStyle.Bold);
            cdDataPoint.LegendText = "Bankkártyás fizetés";
            cdDataPoint.IsValueShownAsLabel = false;
            cdDataPoint.Label = $"{sumChart.BankValue} ft";
            chart2.Series["Összesített napi fizetések"].Points.Add(cdDataPoint);

            //sum chart - cash
            DataPoint moneyDataPoint = new DataPoint(0D, (double)sumChart.MoneyValue);
            moneyDataPoint.Color = Color.Green;
            moneyDataPoint.LabelForeColor = Color.White;
            moneyDataPoint.Font = new Font(FontFamily.GenericSerif, 11f, FontStyle.Bold);
            moneyDataPoint.LegendText = "Készpénzes fizetés";
            moneyDataPoint.IsValueShownAsLabel = false;
            moneyDataPoint.Label = $"{sumChart.MoneyValue} ft";
            chart2.Series["Összesített napi fizetések"].Points.Add(moneyDataPoint);   
        }

        private void LoadMabChart()
        {
            if (chart1.Series.Count > 0)
            {
                chart1.Series[0].Points.Clear();
            }

            DataPoint cdDataPoint = new DataPoint(0D, (double)mabChart.BankValue);
            cdDataPoint.Color = Color.Blue;
            cdDataPoint.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Bold);
            cdDataPoint.Label = "Bankkártyás fizetés";
            cdDataPoint.LegendText = "Bankkártyás fizetés";
            chart1.Series["Fizetés"].IsVisibleInLegend = false;
            chart1.Series["Fizetés"].Points.Add(cdDataPoint);
            creditCardPaymentLb.Text = mabChart.BankValue.ToString() + " ft";

            DataPoint moneyDataPoint = new DataPoint(0D, (double)mabChart.MoneyValue);
            moneyDataPoint.Color = Color.Green;
            moneyDataPoint.Font = new Font(FontFamily.GenericSansSerif, 9f, FontStyle.Bold);
            moneyDataPoint.Label = "Készépénzes fizetés";
            moneyDataPoint.LegendText = "Bankkártyás fizetés";
            chart1.Series["Fizetés"].Points.Add(moneyDataPoint);
            moneyPaymentLb.Text = mabChart.MoneyValue.ToString() + " ft";
        }
        #endregion
    }
}
