using TicketSeller.Views.Munkaképernyő.UserManager;

namespace TicketSeller.Views
{
    public partial class UserManagerView : Form, IUserManagerView
    {
        private static UserManagerView instance;

        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private CustomerTypeHelper userCategory;

        public UserManagerView()
        {
            InitializeComponent();

            InitializeEvents();

            userCategory = CustomerTypeHelper.Adult;

            tabControl1.TabPages.Remove(userDetailsTabPage);
        }

        //This method register all events the form can raise...
      

        #region PROPS
        public string Message
        {
            get => message;
            set => message = value;
        }
        public TabControl TabControl
        {
            get => tabControl1;
            set => tabControl1 = value;
        }
        public string UserName
        {
            get => nameTb.Text;
            set => nameTb.Text = value;
        }
        public int UserBirthYear
        {
            get => (int)yearNud.Value;
            set
            {
                if (value < yearNud.Minimum)
                    yearNud.Value = yearNud.Minimum;
                else if (value > yearNud.Maximum)
                    yearNud.Value = yearNud.Maximum;
                else
                    yearNud.Value = value;
            }
        }
        public int UserId
        {
            get => int.Parse(idVal.Text);
            set => idVal.Text = value.ToString();
        }
        public string UserIdentifier
        {
            get => identifierVal.Text;
            set => identifierVal.Text = value;
        }
        public int? UserTicketId
        {
            get
            {
                if (!string.IsNullOrEmpty(ticketIdVal.Text))
                {
                    return int.Parse(ticketIdVal.Text);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ticketIdVal.Text = value?.ToString();
            }
        }
        public int UserBoughtTicket
        {
            get => int.Parse(boughtTicketVal.Text ?? "0");
            set => boughtTicketVal.Text = (10 - value).ToString();
        }
        public int? UserDiscountId
        {
            get
            {
                if (!string.IsNullOrEmpty(discountIdVal.Text))
                {
                    return int.Parse(discountIdVal.Text);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                discountIdVal.Text = value?.ToString();
            }
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public bool IsEdit
        {
            get => isEdit;
            set => isEdit = value;
        }
        public CustomerTypeHelper UserCategory 
        {
            get
            {
                var ctg = categoryCb.SelectedItem.ToString();

                switch (ctg)
                {
                    case "Felnőtt":
                        userCategory = CustomerTypeHelper.Adult;
                        break;
                    case "Nyugdíjas":
                        userCategory = CustomerTypeHelper.Retired;
                        break;
                    case "26 éven aluli":
                        userCategory = CustomerTypeHelper.YoungAdult;
                        break;
                    case "Diák":
                        userCategory = CustomerTypeHelper.Student;
                        break;
                    case "Hátrányos helyzetű":
                        userCategory = CustomerTypeHelper.Diasadvantaged;
                        break;
                    case "Dolgozó":
                        userCategory = CustomerTypeHelper.Worker;
                        break;
                    default:
                        userCategory = CustomerTypeHelper.Adult;
                        break;
                }

                return userCategory;
            }
            set
            {
                categoryCb.SelectedItem = value;
            }
        }
        public string? Category
        {
            get => categoryCb.Text;
            set => categoryCb.Text = value;
        }

        #endregion

        #region EVENTS
        public event EventHandler AddNewUser;
        public event EventHandler DeleteUser;
        public event EventHandler EditUser;
        public event EventHandler SaveChanges;
        public event EventHandler CancelChanges;
        #endregion

        #region METHODS
        private void InitializeEvents()
        {
            saveChangeBtn.Click += delegate
            {
                SaveChanges?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    MessageBox.Show(message);
                    ShowUsers();
                }
                else
                {
                    MessageBox.Show(message);
                    ShowUsers();
                }
            };
            cancelChangesBtn.Click += delegate
            {
                CancelChanges?.Invoke(this, EventArgs.Empty);
                ShowUsers();
            };
            addNewUserBtn.Click += delegate
            {
                ShowUserDetails();
                AddNewUser?.Invoke(this, EventArgs.Empty);
            };
            editUserBtn.Click += delegate
            {
                ShowUserDetails();
                EditUser?.Invoke(this, EventArgs.Empty);
            };
            deleteUserBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUser?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
            };
        }

        public static UserManagerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UserManagerView();
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

        public void SetUsersListBindingSource(BindingSource userList)
        {
            userDtg.DataSource = userList;
        }

        public void ShowUserDetails()
        {
            if (!tabControl1.TabPages.Contains(userDetailsTabPage))
                tabControl1.TabPages.Add(userDetailsTabPage);
            tabControl1.SelectTab(1);
        }

        public void ShowUsers()
        {
            tabControl1.TabPages.Remove(userDetailsTabPage);
            tabControl1.SelectTab(0);
        }
        #endregion
    }
}
