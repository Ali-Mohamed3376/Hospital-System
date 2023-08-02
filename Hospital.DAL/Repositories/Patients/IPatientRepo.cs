using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;

namespace Hospital.DAL.Repositories.Patients
{
    public interface IPatientRepo:IGenericRepo<Patient>
    {
        IEnumerable<Patient> GetPatientsForDoctor(Guid id);
    }
}
