using TicketSeller.Model;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views.Munkaképernyő;
using TicketSeller.Views.Munkaképernyő.TicketSell.Functions;

namespace TicketSeller.Presenter
{
    internal class TicketSellRepresenter
    {
        private ITicketSellView view;
        private ITicketSellRepository repository;
        private IEnumerable<Customer> customers;
        private List<City> destinations;
        private IEnumerable<Ticket> tickets;
        private Cashier cashier;

        public TicketSellRepresenter(ITicketSellView view, ITicketSellRepository repository, Cashier cashier)
        {
            this.view = view;
            this.repository = repository;

            // -- Initialize state --

            InitializeFields(cashier);

            InitializeEvents();

            view.Show();
        }

        private void InitializeFields(Cashier cashier)
        {
            try
            {
                this.cashier = cashier == null ? throw new Cashier.CashierNotFoundException() : cashier;
                customers = this.repository.GetAllCustomers();
                destinations = this.repository.GetAllCities().ToList();
                destinations.Remove(cashier.Worker.City);
                tickets = this.repository.GetAllTickets();
            }
            catch (Cashier.CashierNotFoundException)
            {
                MessageBox.Show("There is no cashier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeEvents()
        {
            //on search and select user
            view.SearchUserButton += OnSearchUser;
            view.SearchUserBarSelectedIndexChanged += OnSelectUser;
            view.ChooseUserButton += OnChooseUser;
            view.NotRegisteredButton += OnChooseUserNotRegistered;

            //on select ticket and dest.
            view.PreTicketBackBtn += OnChooseTicketBack;
            view.PreTicketNextBtn += OnChooseTicketNext;

            //on buy
            view.ConfirmTicketBack += OnConfirmTicketBack;
            view.ConfirmTicketBuy += OnConfirmTicketBuy;
        }

        #region FORM_EVENTS
        private void OnRefreshForm(object? sender, EventArgs e)
        {

        }
        #endregion

        #region CHOOSEUSER

        private void OnSearchUser(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(view.ChooseUser.SearchValue))
            {
                view.FoundUsers.Clear();

                foreach (var c in customers)
                {
                    if (c.Identifier.Contains(view.ChooseUser.SearchValue))
                    {
                        view.FoundUsers.Add(c.Identifier);
                    }
                }
            }
        }

        private void OnSelectUser(object? sender, EventArgs e)
        {
            var searchResult = view.FoundUsers.Where(id => id == view.ChooseUser.SearchResult).FirstOrDefault();

            if (searchResult != null) view.Model.Customer = repository.GetCustomerByIdentifier(searchResult);
            else view.Model.Customer = new Customer();

            ShowUserDetails();
        }

        private void ShowUserDetails()
        {
            if (view.Model.Customer != null)
            {
                if (view.Model.Customer != null)
                {
                    view.ChooseUser.IsSuccessful = true;
                    view.ChooseUser.IsRegistered = true;
                }
                else
                {
                    view.ChooseUser.IsSuccessful = false;
                    view.ChooseUser.IsRegistered = false;
                }
            }
        }

        private void OnChooseUser(object? sender, EventArgs e)
        {
            LoadPreTicketFields();
        }

        private void LoadPreTicketFields()
        {
            view.TicketDestinations = destinations.ToList();
            view.TicketTickets = tickets.ToList();
        }

        private void OnChooseUserNotRegistered(object? sender, EventArgs e)
        {
            view.ChooseUser.IsRegistered = false;
            LoadPreTicketFields();
        }
        #endregion

        #region CHOOSETICKET
        private void OnChooseTicketBack(object? sender, EventArgs e)
        {
            view.ChooseTicket.IsSuccessful = false;
        }
        private void OnChooseTicketNext(object? sender, EventArgs e)
        {
            if (view.Model.TicketDestination != null
            && view.Model.Ticket != null)
            {
                view.ChooseTicket.IsSuccessful = true;

                if (view.ChooseUser.IsRegistered)
                {
                    if ((bool)view.Model.Ticket.IsTicket)
                        view.Model.Customer.BoughtTicket += 1;
                }
                else
                {
                    view.Model.Customer = new Customer();
                    var discount = repository.GetDiscountByTicketId(view.Model.Ticket.Id);
                    if (discount != null)
                        view.Model.Customer.Discount = discount;
                }

                view.ChooseTicket.FromCityName = cashier.Worker.City.Name;
                view.ChooseTicket.Distance = repository.GetFromToDistance(cashier.Worker.City, view.Model.TicketDestination);
                view.ChooseTicket.Price = PriceCalculator.Calculate(view.ChooseUser, view.ChooseTicket, view.Model.Customer, view.Model.Ticket, repository);
            }
        }
        #endregion    

        #region CONFIRMTICKET
        private void OnConfirmTicketBack(object? sender, EventArgs e)
        {
            if (view.ChooseUser.IsRegistered)
                if ((bool)view.Model.Ticket.IsTicket)
                    view.Model.Customer.BoughtTicket -= 1;
        }

        private void OnConfirmTicketBuy(object? sender, EventArgs e)
        {
            //check paymethod is picked
            if (view.Model.PayMethodIsValid())
            {
                view.Model.IsSuccessful = true;
                view.ConfirmTicket.IsSuccessful = true;
            }
            else
            {
                view.ConfirmTicket.IsSuccessful = false;
                view.Model.Message = $"Please select a pay method\nCash or Credit card";
                return;
            }

            //On sell ticket
            try
            {
                if (view.ConfirmTicket.IsSuccessful && cashier != null)
                {
                    if (view.ChooseUser.IsRegistered)
                    {
                        if (view.Model.Customer.BoughtTicket >= 10)
                            repository.SetCustomerBoughtTicketCountToNull(view.Model.Customer);
                        repository.SellTicket(view.Model.Customer, view.Model.Ticket, cashier.Worker, view.ChooseTicket.Price, view.Model.PayWithCreditCard());
                        view.ConfirmTicket.Message = $"{view.Model.Customer.Name} felhasználó vásárolt egy {view.Model.Ticket.Name} jegyet sikeresen.;";
                    }
                    else
                    {
                        repository.SellTicket(view.Model.Customer.Discount, view.Model.Ticket, cashier.Worker, view.ChooseTicket.Price, view.Model.PayWithCreditCard());
                        view.ConfirmTicket.Message = $"{view.Model.Ticket.Name} jegy sikeresen eladva.;";
                    }

                    InitializeFields(cashier);
                }
            }
            catch (Exception ex)
            {
                view.Model.Message = ex.Message;
            }

        }
        #endregion
    }
}
