namespace Hospital.BL.ViewModels.Doctors
{
    public class DoctorVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public int PerofrmancRate { get; set; }
    }
}
