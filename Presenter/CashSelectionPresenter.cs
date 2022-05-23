using TicketSeller.Model;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views.Kezdőképernyő;

namespace TicketSeller.Presenter
{
    internal class CashSelectionPresenter
    {
        private ICashSelectionView view;
        private ICashRepository repository;
        private Cashier cashier;
        private MainPresenter mainPresenter;

        public CashSelectionPresenter(ICashSelectionView view, ICashRepository repository, Cashier cashier, MainPresenter mainPresenter)
        {
            this.view = view;
            this.repository = repository;
            this.cashier = cashier;
            this.mainPresenter = mainPresenter;

            InitializeEvents();

            this.view.Show();
        }

        private void InitializeEvents()
        {
            this.view.SubmitForm += OnSubmitForm;
            this.view.LoadForm += OnFormLoad;
            this.view.CityLisBoxSelectionChanged += OnCityListBoxIndexChanged;
            this.view.ServicesLisBoxSelectionChanged += OnServicesListBoxIndexChanged;
        }

        private void OnFormLoad(object? sender, EventArgs e)
        {
            //a city-ket betölti

            IEnumerable<City> cities = repository.GetAll();

            if (cities.Count() == 0) return;

            foreach (var c in cities)
            {
                view.cityListBox.Items.Add(c.Name);
            }
        }

        #region ON_CITY_CHOOSE
        private void OnCityListBoxIndexChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(view.CityName))
            {
                view.servicesListBox.Items.Clear();
                view.selectedListBox.Items.Clear();
                // IEnumerable<City> services = _repository.GetServices(cityName);
                view.servicesListBox.Items.Add("Pénztár");
            }
        }
        #endregion

        #region ON_SERVICE_CHOOSE
        private void OnServicesListBoxIndexChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(view.ServiceName))
            {
                view.selectedListBox.Items.Clear();

                City cityCashes = repository.GetByCityName(view.CityName);

                for (int i = 1; i <= cityCashes.CashCount; i++)
                {
                    view.selectedListBox.Items.Add(i);
                }
            }
        }
        #endregion

        private void OnSubmitForm(object? sender, EventArgs e)
        {
            if (view.ReadyToSubmit)
            {
                try
                {
                    var actWorker = repository.GetWorker(view.CityName,int.Parse(view.CashRegistryId));
                    if (actWorker == null)
                    {
                        MessageBox.Show("Jelenleg az összes dolgozó elfoglalt.");
                        return;
                    }
                    else
                    {
                        cashier.SetWorker(actWorker);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cashier.SetCityName(view.CityName);
                cashier.SetService(view.ServiceName);
                cashier.SetCashRegistryId(int.Parse(view.CashRegistryId));

                mainPresenter.RedirectToDashboard();
            }
        }
    }
}
