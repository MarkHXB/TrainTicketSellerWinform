using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSeller.Views.Kezdőképernyő
{
    internal interface ICashSelectionView
    {
        string? CityName { get; set; }
        string? ServiceName { get; set; }
        string?CashRegistryId { get; set; }
        bool ReadyToSubmit { get; }
        ListBox cityListBox { get; set; }
        ListBox servicesListBox { get; set; }
        ListBox selectedListBox { get; set; }

        event EventHandler LoadForm;
        event EventHandler CityLisBoxSelectionChanged;
        event EventHandler ServicesLisBoxSelectionChanged;
        event EventHandler SelectedLisBoxSelectionChanged;
        event EventHandler SubmitForm;
        event EventHandler LisBoxSelectionChanged;

        void Show();
    }
}
