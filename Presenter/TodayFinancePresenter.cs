using TicketSeller.Model;
using TicketSeller.Views;
using TicketSeller.Repositories.Interfaces;


namespace TicketSeller.Presenter
{
    internal class TodayFinancePresenter
    {
        private ITodayFinanceView view;
        private ITodayFinanceRepository repository;
        private Cashier cashier;

        public TodayFinancePresenter(ITodayFinanceView view, ITodayFinanceRepository repository, Cashier cashier)
        {
            InitializeFields(view,repository,cashier);
            InitializeEvents();
            view.Show();
        }

        #region METHODS-ON-START
        private void InitializeFields(ITodayFinanceView view, ITodayFinanceRepository repository, Cashier cashier)
        {
            try
            {
                this.view = view;
                this.repository = repository;
                this.cashier = cashier == null ? throw new Cashier.CashierNotFoundException() : cashier;
            }
            catch (Cashier.CashierNotFoundException)
            {
                MessageBox.Show("Not found cashier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitializeEvents()
        {
            view.FormLoad += OnFormLoad;
            view.Refresh += OnRefresh;
        }
        #endregion

        #region EVENTS
        private void OnFormLoad(object? sender, EventArgs e)
        {
            if (cashier == null || cashier.Worker.Finances == null) return;
            if(cashier.Worker.Finances.Count == 0)
            {
                view.MoneyAndBankChart.Message = $"Nem történt pénzügyi tranzakció még a mai napon\nLekérdezte: {cashier.Worker.Name}";
                view.SumChart.Message = $"Nem történt pénzügyi tranzakció még a mai napon\nLekérdezte: {cashier.Worker.Name}";
                view.MoneyAndBankChart.IsSuccessfullyLoaded = false;
                view.SumChart.IsSuccessfullyLoaded = false;
                return;
            }

            try
            {
                DateTime now = DateTime.Now;

                var creditCardPayments = cashier.Worker.Finances.Where(
                    f => (bool)f.PayWithCreditCard == true
                && CheckDateTime(now, f.DateTime)
                && f.WorkerId == cashier.Worker.Id);

                var moneyPayments = cashier.Worker.Finances.Where(
                    f => (bool)f.PayWithCreditCard == false
                && CheckDateTime(now, f.DateTime)
                && f.WorkerId == cashier.Worker.Id);

                int creditCardSum = creditCardPayments.Select(f => f.Price).Sum();
                int moneySum = moneyPayments.Select(f => f.Price).Sum();

                view.MoneyAndBankChart.BankValue = creditCardSum;
                view.MoneyAndBankChart.MoneyValue = moneySum;

                view.SumChart.BankValue = creditCardSum;
                view.SumChart.MoneyValue = moneySum;

                view.MoneyAndBankChart.IsSuccessfullyLoaded = true;
                view.SumChart.IsSuccessfullyLoaded = true;
            }
            catch (Exception ex)
            {
                view.MoneyAndBankChart.Message = ex.Message;
                view.SumChart.Message = ex.Message;
                view.MoneyAndBankChart.IsSuccessfullyLoaded = false;
                view.SumChart.IsSuccessfullyLoaded = false;
            }
        }

        private void OnRefresh(object? sender, EventArgs e)
        {
            if (cashier == null || cashier.Worker.Finances == null) return;
            if (cashier.Worker.Finances.Count == 0)
            {
                view.MoneyAndBankChart.Message = $"Nem történt pénzügyi tranzakció még a mai napon\nLekérdezte: {cashier.Worker.Name}";
                view.SumChart.Message = $"Nem történt pénzügyi tranzakció még a mai napon\nLekérdezte: {cashier.Worker.Name}";
                view.MoneyAndBankChart.IsSuccessfullyLoaded = false;
                view.SumChart.IsSuccessfullyLoaded = false;
                return;
            }

            try
            {
                DateTime now = DateTime.Now;

                var creditCardPayments = cashier.Worker.Finances.Where(
                    f => (bool)f.PayWithCreditCard == true
                && CheckDateTime(now, f.DateTime)
                && f.WorkerId == cashier.Worker.Id);

                var moneyPayments = cashier.Worker.Finances.Where(
                    f => (bool)f.PayWithCreditCard == false
                && CheckDateTime(now, f.DateTime)
                && f.WorkerId == cashier.Worker.Id);

                int creditCardSum = creditCardPayments.Select(f => f.Price).Sum();
                int moneySum = moneyPayments.Select(f => f.Price).Sum();

                view.MoneyAndBankChart.BankValue = creditCardSum;
                view.MoneyAndBankChart.MoneyValue = moneySum;

                view.SumChart.BankValue = creditCardSum;
                view.SumChart.MoneyValue = moneySum;

                view.MoneyAndBankChart.IsSuccessfullyLoaded = true;
                view.SumChart.IsSuccessfullyLoaded = true;
            }
            catch (Exception ex)
            {
                view.MoneyAndBankChart.Message = ex.Message;
                view.SumChart.Message = ex.Message;
                view.MoneyAndBankChart.IsSuccessfullyLoaded = false;
                view.SumChart.IsSuccessfullyLoaded = false;
            }
        }

        private bool CheckDateTime(DateTime now, DateTime then)
        {
            return (now.Year == then.Year) && (now.Month == then.Month) && (now.Day == then.Day);
        }
        #endregion
    }
}
