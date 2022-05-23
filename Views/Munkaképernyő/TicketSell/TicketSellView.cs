using TicketSeller.Model;
using TicketSeller.Views.Munkaképernyő.TicketSell;
using TicketSeller.Views.Munkaképernyő.TicketSell.Models;
using TicketSeller.Views.Munkaképernyő.TicketSell.Tickets;

namespace TicketSeller.Views.Munkaképernyő
{
    public partial class TicketSellView : Form, ITicketSellView
    {
        private static TicketSellView instance;

        private TicketSellModel model;
        private List<string> foundUsers;
        private ChooseUser chooseUser;
        private ChooseTicket chooseTicket;
       
        private List<Ticket> preTicketTickets;
        private ConfirmTicket confirmTicket;

        private List<City> ticketDestinations;
        private City ticketDestination;


        public TicketSellView()
        {
            InitializeComponent();

            model = new TicketSellModel();

            foundUsers = new List<string>();
            searchForCb.Text = (string)searchForCb.Items[0];
            preTicketTickets = new List<Ticket>();
            ticketDestinations = new List<City>();
            ticketDestination = new City();

            chooseUser = new ChooseUser();
            confirmTicket = new ConfirmTicket();
            chooseTicket = new ChooseTicket();

            ticketSellerTbc.TabPages.Remove(ticketSellerDataEntry);
            ticketSellerTbc.TabPages.Remove(ticketSellerConfirmTicket);

            RegisterChooseUserEvents();
            RegisterChooseTicketEvents();
            RegisterConfirmTicketEvents();
        }

        #region PROPS

        #region CHOOSEUSER
        public ChooseUser ChooseUser
        {
            get => chooseUser;
            set => chooseUser = value;
        }
        public List<string> FoundUsers
        {
            get => foundUsers;
            set => foundUsers = value;
        }
        #endregion

        #region CHOOSETICKET
        public ChooseTicket ChooseTicket
        {
            get => chooseTicket;
            set => chooseTicket = value;
        }
        public City? TicketDestination
        {
            get
            {
                var selectedDestination = preTicketDestinationsCb.SelectedItem;

                if (selectedDestination == null) return null;

                foreach (var t in ticketDestinations)
                {
                    if (selectedDestination.ToString() == t.Name)
                    {
                        return t;
                    }
                }
                return null;
            }
            set => ticketDestination = value;
        }
        public List<City> TicketDestinations
        {
            get
            {
                return ticketDestinations;
            }
            set
            {
                preTicketDestinationsCb.Items.Clear();
                foreach (var c in value)
                {
                    preTicketDestinationsCb.Items.Add(c.Name);
                    ticketDestinations.Add(c);
                }
            }
        }
        public List<Ticket> TicketTickets
        {
            get
            {
                return preTicketTickets;
            }
            set
            {
                preTicketTicketOrSubCb.Items.Clear();
                foreach (var t in value)
                {
                    preTicketTicketOrSubCb.Items.Add(t.Name);
                    preTicketTickets.Add(t);
                }
            }
        }
        #endregion

        #region CONFIRMTICKET
        public ConfirmTicket ConfirmTicket
        {
            get => confirmTicket;
            set => confirmTicket = value;
        }
        public TicketSellModel Model
        {
            get => model;
            set => model = value;
        }

        #endregion

        #endregion

        #region EVENTS
        public event EventHandler SearchForTextChanged;
        public event EventHandler SearchUserButton;
        public event EventHandler ChooseUserButton;
        public event EventHandler SearchUserBarSelectedIndexChanged;
        public event EventHandler PreTicketBackBtn;
        public event EventHandler PreTicketNextBtn;
        public event EventHandler ConfirmTicketBack;
        public event EventHandler ConfirmTicketBuy;
        public event EventHandler NotRegisteredButton;
        #endregion

        #region METHODS
        private void RegisterChooseUserEvents()
        {
            notRegisteredBtn.Click += delegate
            {
                InitProps();
                NotRegisteredButton?.Invoke(this, EventArgs.Empty);
                ticketSellerTbc.TabPages.Remove(ticketSellerConfirmTicket);
                ticketSellerTbc.TabPages.Add(ticketSellerDataEntry);
                ticketSellerTbc.SelectTab(ticketSellerDataEntry);
            };

            searchUserBar.SelectedIndexChanged += delegate
            {
                ChooseUser.SearchResult = searchUserBar.SelectedItem?.ToString();
                SearchUserBarSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                searchUserBar.DroppedDown = false;

                ShowChoosenUser();
            };

            searchUserBar.TextChanged += delegate
            {
                ChooseUser.SearchValue = searchUserBar.Text.ToUpper();
            };

            searchUserBtn.Click += delegate
            {
                SearchUserButton?.Invoke(this, EventArgs.Empty);
                if (FoundUsers.Count > 0)
                {
                    searchUserBar.Items.Clear();
                    foreach (var identifier in FoundUsers)
                    {
                        searchUserBar.Items.Add(identifier);
                    }
                    searchUserBar.DroppedDown = true;
                }
                else searchUserBar.DroppedDown = false;
            };

            chooseUserBtn.Click += delegate
            {
                if (ChooseUser.IsSuccessful)
                {
                    ticketSellerTbc.TabPages.Add(ticketSellerDataEntry);
                    ticketSellerTbc.SelectTab(ticketSellerDataEntry);
                    ChooseUserButton?.Invoke(this, EventArgs.Empty);
                }
            };
        }
        private void RegisterChooseTicketEvents()
        {
            preTicketBackBtn.Click += delegate
            {
                PreTicketBackBtn?.Invoke(this, EventArgs.Empty);
                ticketSellerTbc.TabPages.Remove(ticketSellerDataEntry);
                ticketSellerTbc.SelectTab(ticketSellerSearch);
            };

            preTicketNextBtn.Click += delegate
            {
                Model.Ticket = Model.GetTicket(preTicketTickets, preTicketTicketOrSubCb);
                Model.TicketDestination = Model.GetTicketDestination(ticketDestinations, preTicketDestinationsCb);

                PreTicketNextBtn?.Invoke(this, EventArgs.Empty);

                if (ChooseTicket.IsSuccessful)
                {
                    ticketSellerTbc.TabPages.Add(ticketSellerConfirmTicket);
                    ticketSellerTbc.SelectTab(ticketSellerConfirmTicket);

                    if (!ChooseUser.IsRegistered)
                    {
                        ShowNonRegisteredTicket();
                    }
                    else
                    {
                        ShowRegisteredTicket();
                    }  
                }
            };
        }
        private void RegisterConfirmTicketEvents()
        {
            payWithCashBtn.Click += delegate
            {
                this.Model.PayMethod = PayHelper.Money;
                payWithCreditCardBtn.FlatAppearance.BorderSize = 0;
                payWithCashBtn.FlatAppearance.BorderSize = 5;
                payWithCashBtn.FlatAppearance.BorderColor = Color.Yellow;
            };
            payWithCreditCardBtn.Click += delegate
            {
                this.Model.PayMethod = PayHelper.CreditCard;
                payWithCashBtn.FlatAppearance.BorderSize = 0;
                payWithCreditCardBtn.FlatAppearance.BorderSize = 5;
                payWithCreditCardBtn.FlatAppearance.BorderColor = Color.Yellow;
            };

            confirmTicketBackBtn.Click += delegate
            {
                ConfirmTicketBack?.Invoke(this, EventArgs.Empty);
                ticketSellerTbc.TabPages.Remove(ticketSellerConfirmTicket);
                ticketSellerTbc.SelectTab(ticketSellerDataEntry);
               
            };
            confirmTicketBuyBtn.Click += delegate
            {
                if (ChooseUser.IsSuccessful || !ChooseUser.IsRegistered)
                {
                    if (ChooseTicket.IsSuccessful)
                    {
                        ConfirmTicketBuy?.Invoke(this, EventArgs.Empty);
                        if (!this.Model.IsSuccessful)
                        {
                            MessageBox.Show(this.Model.Message);
                        }

                        if (ConfirmTicket.IsSuccessful)
                        {
                            MessageBox.Show(ConfirmTicket.Message);

                            InitProps();
                            ShowChoosenUser();
                            ticketSellerTbc.TabPages.Remove(ticketSellerConfirmTicket);
                            ticketSellerTbc.TabPages.Remove(ticketSellerDataEntry);
                            ticketSellerTbc.SelectTab(ticketSellerSearch);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Válaszd ki a jegyet / bérletet!");
                        this.Invoke(ConfirmTicketBack);
                    }
                }
                else
                {
                    MessageBox.Show("Válaszd ki a felhasználót!");
                    this.Invoke(ConfirmTicketBack);
                    this.Invoke(PreTicketBackBtn);
                }
            };
        }
        private void ShowChoosenUser()
        {
            userNameVal.Text = Model.Customer.Name;
            userAgeVal.Text = Model.Customer.BirthYear.ToString();
            userBTicketsVal.Text = Model.Customer.BoughtTicket.ToString();
            userTypeVal.Text = Model.Customer.Discount?.Type?.ToString();
        }
        private void InitProps()
        {
            this.Model = new TicketSellModel();
            this.ChooseUser = new ChooseUser();
            this.ChooseTicket = new ChooseTicket();
            this.ConfirmTicket = new ConfirmTicket();
            this.FoundUsers = new List<string>();
            this.TicketDestinations = new List<City>();
            this.TicketTickets = new List<Ticket>();
            userNameVal.Text = string.Empty;
            userAgeVal.Text = string.Empty;
            userBTicketsVal.Text = string.Empty;
            userTypeVal.Text = string.Empty;
            searchUserBar.Text = string.Empty;
            searchUserBar.SelectedItem = null;
            payWithCashBtn.FlatAppearance.BorderSize = 0;
            payWithCreditCardBtn.FlatAppearance.BorderSize = 0;
        }

        public void ShowRegisteredTicket()
        {
            if (confirmTicketPanel.Controls.Count > 0)
                confirmTicketPanel.Controls.Clear();
            RegisteredCustomerTicket ticketControl = RegisteredCustomerTicket.GetInstance();
            ticketControl.LoadControl(Model.Customer, Model.Ticket, ChooseTicket, TicketDestination);
            ticketControl.Dock = DockStyle.Fill;
            confirmTicketPanel.Size = new Size(ticketControl.Size.Width,ticketControl.Size.Height);
            confirmTicketPanel.Controls.Add(ticketControl);
        }
        public void ShowNonRegisteredTicket()
        {
            if (confirmTicketPanel.Controls.Count > 0)
                confirmTicketPanel.Controls.Clear();
            NonRegisteredCustomerTicket ticketControl = NonRegisteredCustomerTicket.GetInstance();
            ticketControl.LoadControl(Model.Customer, Model.Ticket, ChooseTicket,TicketDestination);
            ticketControl.Dock = DockStyle.Fill;
            confirmTicketPanel.Size = new Size(ticketControl.Size.Width, ticketControl.Size.Height);
            confirmTicketPanel.Controls.Add(ticketControl);
        }

        public static TicketSellView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TicketSellView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        #endregion
    }
}
