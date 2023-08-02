namespace Hospital.DAL.Data.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int PerofrmancRate { get; set; }

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
