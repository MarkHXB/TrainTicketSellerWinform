namespace TicketSeller.Views.Munkaképernyő.TodayFinance
{
    public abstract class PaymentChart
    {
        public string Name { get; set; }
        public bool IsSuccessfullyLoaded { get; set; }
        public string Message { get; set; }
    }
    public class MoneyAndBankChart : PaymentChart
    {
        public int MoneyValue { get; set; }
        public int BankValue { get; set; }
    }
    public class SumChart : PaymentChart
    {
        public int MoneyValue { get; set; }
        public int BankValue { get; set; }
        public int SumValue { get => (MoneyValue + BankValue); }
    }
}
