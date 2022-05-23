namespace TicketSeller.Views.Kezdőképernyő
{
    public partial class CashSelectionView : Form, ICashSelectionView
    {
        private static CashSelectionView? _instance;

        public CashSelectionView()
        {
            InitializeComponent();
            this.Load += delegate { LoadForm?.Invoke(this, EventArgs.Empty); };
            cityLb.SelectedIndexChanged += delegate { CityLisBoxSelectionChanged?.Invoke(this, EventArgs.Empty); };
            servicesLb.SelectedIndexChanged += delegate { ServicesLisBoxSelectionChanged?.Invoke(this, EventArgs.Empty); };
            selectedLb.SelectedIndexChanged += delegate { SelectedLisBoxSelectionChanged?.Invoke(this, EventArgs.Empty); };
            confirmViewBtn.Click += delegate { SubmitForm?.Invoke(this, EventArgs.Empty); };
        }

        public ListBox cityListBox
        {
            get => cityLb;
            set => cityLb = value;
        }
        public ListBox servicesListBox
        {
            get => servicesLb;
            set => servicesLb = value;
        }
        public ListBox selectedListBox
        {
            get => selectedLb;
            set => selectedLb = value;
        }
        public string? CityName
        {
            get => cityLb.SelectedItem?.ToString();
            set => cityLb.SelectedItem = value;
        }
        public string? ServiceName
        {
            get => servicesLb.SelectedItem?.ToString();
            set => servicesLb.SelectedItem = value;
        }
        public string? CashRegistryId
        {
            get => selectedLb.SelectedItem?.ToString();
            set => selectedLb.SelectedItem = value;
        }
        public bool ReadyToSubmit
        {
            get
            {
                if (!string.IsNullOrEmpty(CityName) &&
                    !string.IsNullOrEmpty(ServiceName) &&
                    !string.IsNullOrEmpty(CashRegistryId))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public event EventHandler SubmitForm;
        public event EventHandler LoadForm;
        public event EventHandler CityLisBoxSelectionChanged;
        public event EventHandler ServicesLisBoxSelectionChanged;
        public event EventHandler SelectedLisBoxSelectionChanged;
        public event EventHandler LisBoxSelectionChanged;

        public static CashSelectionView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new CashSelectionView();
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
    }
}
