namespace CMCS
{
    public class Claim
    {
        public string LecturerName { get; set; } = string.Empty;
        public string LecturerSurname { get; set; } = string.Empty;
        public string SubmissionDate { get; set; } = string.Empty;
        public double HoursWorked { get; set; }
        public double ClaimAmount { get; set; }
        public string Status { get; set; } = "Pending";

        public double HourlyRate { get; set; }
    }
}
