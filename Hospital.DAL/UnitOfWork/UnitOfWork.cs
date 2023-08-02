using Hospital.DAL.Data.Context;
using Hospital.DAL.Repositories.Doctors;
using Hospital.DAL.Repositories.Issues;
using Hospital.DAL.Repositories.Patients;

namespace Hospital.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext context;

        public IDoctorRepo DoctorRepo { get; }

        public IPatientRepo PatientRepo { get; }

        public IIssuesRepo IssuesRepo { get; }

        public UnitOfWork(HospitalContext context, IDoctorRepo doctorRepo, IPatientRepo patientRepo, IIssuesRepo issuesRepo)
        {
            this.context = context;
            DoctorRepo = doctorRepo;
            PatientRepo = patientRepo;
            IssuesRepo = issuesRepo;
        }

        public int Savechanges()
        {
            return context.SaveChanges();
        }
    }
}
