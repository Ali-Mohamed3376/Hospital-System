using Hospital.BL.ViewModels.Patients;

namespace Hospital.BL.ViewModels.Doctors
{
    public class DoctorDetailsVM
    {
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public int PerofrmancRate { get; set; }
        public ICollection<PatientChildVM> Patients { get; set; } = new List<PatientChildVM>();
    }
}