using TicketSeller.Model;
using TicketSeller.Repositories.Interfaces;
using TicketSeller.Views;

namespace TicketSeller.Presenter
{
    internal class UserManagerPresenter
    {
        private IUserManagerView view;
        private IUserManagerRepository repository;
        private BindingSource usersBindingSource;
        private IEnumerable<Customer> userList;

        public UserManagerPresenter(IUserManagerView view, IUserManagerRepository repository)
        {
            this.usersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // -- Initialize state --
            InitializeEvents();
            this.view.SetUsersListBindingSource(usersBindingSource);
            LoadAllUsers();
            this.view.Show();
        }

        #region METHODS
        private void LoadAllUsers()
        {
            try
            {
                userList = repository.GetCustomers().ToList();
                usersBindingSource.DataSource = userList;
            }
            catch (NotSupportedException)
            {
                //do nothing... C# error 
            }

        }
        private void InitializeEvents()
        {
            this.view.AddNewUser += OnAddNewUser;
            this.view.EditUser += OnEditUser;
            this.view.DeleteUser += OnDeleteUser;
            this.view.SaveChanges += OnSaveChanges;
            this.view.CancelChanges += OnCancelChanges;
        }
        private void ClearViewFields()
        {
            view.UserName = string.Empty;
            view.UserBirthYear = 0;
            view.UserId = 0;
            view.UserDiscountId = 0;
            view.UserIdentifier = string.Empty;
            view.UserTicketId = 0;
            view.UserBoughtTicket = 0;
        }
        private string IdentifierGenerator()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 7)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
        private void LoadSelectedUserToEdit()
        {
            //On edit user
            if (view.IsEdit)
            {
                Customer? user = usersBindingSource.Current as Customer;

                if (user == null) return;

                view.UserName = user.Name;
                view.UserBirthYear = user.BirthYear;
                view.UserId = user.Id;
                view.UserDiscountId = user.DiscountId;
                view.UserIdentifier = user.Identifier;
                view.UserTicketId = user.TicketId;
                view.UserBoughtTicket = user.BoughtTicket;
                view.Category = user.Discount?.Type?.ToString();
            }
            //On add new user 
            else
            {
                Customer user = repository.GetLastCustomer();

                if (user == null)
                {
                    view.UserId = 1;
                    view.UserIdentifier = IdentifierGenerator();
                    view.UserTicketId = 0;
                    view.UserBoughtTicket = 0;
                }
                else
                {
                    view.UserId = (user.Id + 1);
                    view.UserIdentifier = IdentifierGenerator();
                    view.UserTicketId = 0;
                    view.UserBoughtTicket = 0;
                }
            }
        }
        #endregion

        #region EVENTS
        private void OnCancelChanges(object? sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void OnSaveChanges(object? sender, EventArgs e)
        {
            var model = new Customer();
            model.Identifier = view.UserIdentifier;
            model.BoughtTicket = view.UserBoughtTicket;
            model.BirthYear = view.UserBirthYear;
            model.Name = view.UserName;

            model.Discount = repository.GetDiscount(view.UserCategory) ?? throw new Exception("Discount not found");

            if (view.UserTicketId != 0)
            {
                model.TicketId = view.UserTicketId;
            }

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) // on edit customer
                {
                    repository.Edit(model);
                    view.Message = $"[Id: {model.Id}]\n[Identifier: {model.Identifier}]\nCustomer edited successfuly";
                }
                else // on add new customer
                {
                    repository.Add(model);
                    view.Message = $"[Id: {model.Id}]\n[Identifier: {model.Identifier}]\nNew customer added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllUsers();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

            ClearViewFields();
        }

        private void OnDeleteUser(object? sender, EventArgs e)
        {
            try
            {
                var model = usersBindingSource.Current as Customer;

                if (model == null) throw new Exception($"Selected customer not found");

                repository.Delete(model);

                view.IsSuccessful = true;
                view.Message = $"[Id: {model.Id}]\n[Identifier: {model.Identifier}]\nCustomer deleted successfuly";

                LoadAllUsers();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occured on deleting customer";
            }
        }

        private void OnEditUser(object? sender, EventArgs e)
        {
            view.IsEdit = true;

            LoadSelectedUserToEdit();
        }

        private void OnAddNewUser(object? sender, EventArgs e)
        {
            view.IsEdit = false;

            LoadSelectedUserToEdit();
        }
        #endregion
    }
}
