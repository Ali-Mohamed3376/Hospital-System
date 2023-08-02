using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;

namespace Hospital.DAL.Repositories.Doctors
{
    public interface IDoctorRepo:IGenericRepo<Doctor>
    {
        Doctor? GetByIdWithPatientsAndIssues(Guid id);
    }
}
