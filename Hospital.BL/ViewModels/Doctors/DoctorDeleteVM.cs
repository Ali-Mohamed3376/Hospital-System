namespace Hospital.BL.ViewModels.Doctors
{
    public class DoctorDeleteVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int PerofrmancRate { get; set; }
    }
}
