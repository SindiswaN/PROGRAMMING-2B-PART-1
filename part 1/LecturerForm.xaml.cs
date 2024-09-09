using System.Collections.Generic;
using System.Windows;

namespace CMCS
{
    public partial class LecturerForm : Window
    {
        // A static list to store claims submitted by lecturers
        public static List<Claim> ClaimsList = new List<Claim>();

        public LecturerForm()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Gather claim details
            string lecturerName = LecturerName.Text;
            string surname = LecturerSurname.Text;
            string date = ClaimDate.SelectedDate?.ToString("yyyy-MM-dd") ?? "N/A";
            string hoursWorked = HoursWorked.Text;
            string hourlyRate = HourlyRate.Text;

            // Validate input (can be expanded with more robust checks)
            if (string.IsNullOrWhiteSpace(lecturerName) || string.IsNullOrWhiteSpace(hoursWorked) || string.IsNullOrWhiteSpace(hourlyRate))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Calculate the claim amount
            double claimAmount = double.Parse(hoursWorked) * double.Parse(hourlyRate);

            // Create a new claim and add it to the list
            var newClaim = new Claim
            {
                LecturerName = lecturerName,
                LecturerSurname = surname,
                SubmissionDate = date,
                HoursWorked = int.Parse(hoursWorked),
                HourlyRate = double.Parse(hourlyRate),
                ClaimAmount = claimAmount,
                Status = "Pending"
            };

            ClaimsList.Add(newClaim);

            // Confirmation message
            MessageBox.Show($"Claim submitted! \nLecturer: {lecturerName} {surname} \nDate: {date} \nHours Worked: {hoursWorked} \nHourly Rate: {hourlyRate} \nClaim Amount: {claimAmount}");

            // Clear form fields
            LecturerName.Clear();
            LecturerSurname.Clear();
            HoursWorked.Clear();
            HourlyRate.Clear();
            ClaimDate.SelectedDate = null;
        }

        private void UploadFile_Click(object sender, RoutedEventArgs e)
        {
            // Logic for file upload (can use OpenFileDialog here)
            MessageBox.Show("File Uploaded Successfully!");
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
