
using System.Windows;
using WpfDashboard.DataAccess;
using System.Threading.Tasks;

namespace WpfDashboard
{
    public partial class MainWindow : Window
    {
        private readonly DatabaseHelper _db;
        private readonly ApiHelper _api;

        public MainWindow()
        {
            InitializeComponent();
            _db = new DatabaseHelper();
            _api = new ApiHelper();
        }

        private async void LoadData_Click(object sender, RoutedEventArgs e)
        {
            UsersList.Items.Clear();
            var users = _db.GetAllUsers();
            foreach (var user in users)
                UsersList.Items.Add($"• {user.Name} — {user.Email}");
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameInput.Text) && !string.IsNullOrWhiteSpace(EmailInput.Text))
            {
                _db.InsertUser(NameInput.Text, EmailInput.Text);
                NameInput.Clear();
                EmailInput.Clear();
                LoadData_Click(null, null);
            }
        }

        private async void LoadApi_Click(object sender, RoutedEventArgs e)
        {
            UsersList.Items.Clear();
            var apiUsers = await _api.GetUsersAsync();
            foreach (var user in apiUsers)
                UsersList.Items.Add($"→ {user.Name} — {user.Email}");
        }
    }
}
