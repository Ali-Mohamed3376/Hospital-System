using Hospital.DAL.Repositories.Doctors;
using Hospital.DAL.Repositories.Issues;
using Hospital.DAL.Repositories.Patients;

namespace Hospital.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IDoctorRepo DoctorRepo { get; }
        public IPatientRepo PatientRepo { get; }
        public IIssuesRepo IssuesRepo{ get; }

        int Savechanges();
    }
}
