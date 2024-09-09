using System.Windows;

namespace CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Make sure this line exists
        }

        // Event handlers for buttons
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show();
            this.Close();
        }

        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            ViewClaims viewClaims = new ViewClaims();
            viewClaims.Show();
            this.Close();
        }

        private void CoordinatorView_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorView coordinatorView = new CoordinatorView();
            coordinatorView.Show();
            this.Close();
        }
    }
}
