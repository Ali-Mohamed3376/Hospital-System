﻿namespace Hospital.BL.ViewModels.Doctors
{
    public class DoctorUpdateVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public decimal Salary { get; set; }
    }
}
