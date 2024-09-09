using System.Windows;

namespace CMCS
{
    public partial class CoordinatorView : Window
    {
        public CoordinatorView()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Use the static list from LecturerForm to populate the claims
            ClaimsListBox.ItemsSource = LecturerForm.ClaimsList;
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve the claim
            if (ClaimsListBox.SelectedItem is Claim selectedClaim)
            {
                selectedClaim.Status = "Approved";
                MessageBox.Show($"Claim approved for {selectedClaim.LecturerName} {selectedClaim.LecturerSurname}.");
                ClaimsListBox.Items.Refresh();
            }
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to reject the claim
            if (ClaimsListBox.SelectedItem is Claim selectedClaim)
            {
                selectedClaim.Status = "Rejected";
                MessageBox.Show($"Claim rejected for {selectedClaim.LecturerName} {selectedClaim.LecturerSurname}.");
                ClaimsListBox.Items.Refresh();
            }
        }

        private void ClaimsListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle selection changes (optional)
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
