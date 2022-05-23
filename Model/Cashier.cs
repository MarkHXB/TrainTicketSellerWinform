using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSeller.Model
{
    public class Cashier
    {
        public Worker Worker;
        public string? CityName;
        public string? Service;
        public int? CashRegistryId;

        public class CashierNotFoundException : Exception { }

        public Cashier()
        {

        }

        public void SetWorker(Worker worker)
        {
            this.Worker = worker;
        }
        public void SetCityName(string cityName) => this.CityName = cityName;
        public void SetService(string service) => this.Service = service;
        public void SetCashRegistryId(int cashRegistryId) => this.CashRegistryId = cashRegistryId;

        public override string ToString()
        {
            return $"{CityName}\n{CashRegistryId}. {Service}";
        }
    }
}
