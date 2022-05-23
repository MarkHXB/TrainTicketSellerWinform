using TicketSeller.Views.Munkaképernyő.UserManager;

namespace TicketSeller.Views
{
    internal interface IUserManagerView
    {
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        bool IsEdit { get; set; }

        string UserIdentifier { get; set; }
        string UserName { get; set; }
        int UserBirthYear { get; set; }
        int? UserTicketId { get; set; }
        int UserId { get; set; }
        int UserBoughtTicket { get; set; }
        int? UserDiscountId { get; set; }
        string? Category { get; set; }
        CustomerTypeHelper UserCategory { get; set; }


        event EventHandler AddNewUser;
        event EventHandler EditUser;
        event EventHandler DeleteUser;
        event EventHandler SaveChanges;
        event EventHandler CancelChanges;

        void SetUsersListBindingSource(BindingSource userList);

        TabControl TabControl { get; set; }
        void ShowUserDetails();
        void ShowUsers();
        void Show();
    }
}
