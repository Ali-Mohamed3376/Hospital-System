using Hospital.DAL.Data.Models;

namespace Hospital.BL.ViewModels.Patients
{
    public class PatientChildVM
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfIssues  { get; set; }
    }
}
