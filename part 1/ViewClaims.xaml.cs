using System.Windows;

namespace CMCS
{
    public partial class ViewClaims : Window
    {
        public ViewClaims()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Use the static list from LecturerForm to populate the claims
            ClaimsListBox.ItemsSource = LecturerForm.ClaimsList;
        }

        // Back to Menu Button Click Handler
        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
