using Hospital.DAL.Data.Context;
using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;

namespace Hospital.DAL.Repositories.Patients
{
    public class PatientRepo : GenericRepo<Patient>, IPatientRepo
    {
        private readonly HospitalContext context;

        public PatientRepo(HospitalContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Patient> GetPatientsForDoctor(Guid id)
        {
            return context.Set<Patient>().Where(p => p.DoctorId == id);
        }
    }
}
