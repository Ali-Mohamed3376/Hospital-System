using Hospital.DAL.Data.Context;
using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL.Repositories.Doctors
{
    public class DoctorRepo : GenericRepo<Doctor>, IDoctorRepo
    {
        private readonly HospitalContext context;

        public DoctorRepo(HospitalContext context):base(context)
        {
            this.context = context;
        }
        public Doctor? GetByIdWithPatientsAndIssues(Guid id)
        {
            return context.Doctors
                .Include(d => d.Patients)
                    .ThenInclude(p => p.Issues)
                .FirstOrDefault( d => d.Id == id);
        }
    }
}
