using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views.Munkaképernyő.Statistics;

namespace TicketSeller.Presenter
{
    internal class DashboardPresenter
    {
        private IDashboardView view;
        private IDashboardRepository repository;

        public DashboardPresenter(IDashboardView view, IDashboardRepository repository)
        {
            this.view = view;
            this.repository = repository;

            // -- Initialize state --
            InitializeEvents();

            view.Show();
        }

        private void InitializeEvents()
        {
            view.FormLoad += OnFormLoad;
            view.Refresh += OnRefresh;
        }

        private void OnRefresh(object? sender, EventArgs e)
        {
            GetTodayFinances();
            GetWeekFinances();
        }


        #region ON_FORM_LOAD
        private void OnFormLoad(object? sender, EventArgs e)
        {
            GetTodayFinances();
            GetWeekFinances();
        }
        private void GetTodayFinances()
        {
            try
            {
                view.TicketStatistics.Items.Clear();

                var finances = repository.GetCurrentDayFinance();

                if(finances == null || finances.Count() == 0)
                {
                    view.TicketStatistics.IsSuccessfuly = false;
                    view.TicketStatistics.Message = $"Nincs pénzügyi jelentés a mai napra";
                    return;
                }

                foreach (var f in finances)
                {
                    if (view.TicketStatistics.Items.ContainsKey(f.Ticket.Name))
                    {
                        view.TicketStatistics.Items[f.Ticket.Name] += f.Price;
                    }
                    else
                    {
                        view.TicketStatistics.Items.Add(f.Ticket.Name, f.Price);
                    }
                }

                view.TicketStatistics.IsSuccessfuly = true;
            }
            catch (Exception ex)
            {
                view.TicketStatistics.IsSuccessfuly = false;
                view.TicketStatistics.Message = ex.Message;
            }
        }
        private void GetWeekFinances()
        {
            try
            {
                view.MoneyStatistics.Items.Clear();

                var finances = repository.GetCurrentWeekFinance();

                if (finances == null || finances.Count() == 0)
                {
                    view.MoneyStatistics.IsSuccessfuly = false;
                    view.MoneyStatistics.Message = $"Nincs pénzügyi jelentés a hétre :(";
                    return;
                }

                foreach (var f in finances)
                {
                    DateTime date = new DateTime(f.DateTime.Year, f.DateTime.Month, f.DateTime.Day);

                    if (view.MoneyStatistics.Items.ContainsKey(date))
                    {
                        view.MoneyStatistics.Items[date] += f.Price;
                    }
                    else
                    {
                        view.MoneyStatistics.Items.Add(date, f.Price);
                    }
                }

                view.MoneyStatistics.IsSuccessfuly = true;
            }
            catch (Exception ex)
            {
                view.MoneyStatistics.IsSuccessfuly = false;
                view.MoneyStatistics.Message = ex.Message;
            }
        }
        #endregion
    }
}
