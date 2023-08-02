using Hospital.BL.ViewModels.Doctors;
using Hospital.BL.ViewModels.Patients;
using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Doctors;
using Hospital.DAL.UnitOfWork;

namespace Hospital.BL.Manager.Doctors
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IUnitOfWork unitOfWork;

        public DoctorManager(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
       
        public IEnumerable<DoctorVM> GetDoctorVMs()
        {
            IEnumerable<Doctor> doctorsFromDB = unitOfWork.DoctorRepo.GetAll();
            IEnumerable<DoctorVM> doctorVMs = doctorsFromDB.Select(d => new DoctorVM()
            {
                Id = d.Id,
                Name = d.Name,
                Specialization = d.Specialization,
                PerofrmancRate = d.PerofrmancRate,
            });
            return doctorVMs;
        }
        public DoctorVM? GetByID(Guid id)
        {
            Doctor? doctor = unitOfWork.DoctorRepo.GetById(id);

            if (doctor is null) { return null; }

            return new DoctorVM()
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Specialization = doctor.Specialization,
                PerofrmancRate = doctor.PerofrmancRate,
            };
        }
        public DoctorUpdateVM? GetDoctorUpdateVMById(Guid id)
        {
            Doctor? doctor = unitOfWork.DoctorRepo.GetById(id);
            if (doctor is null) { return null; }
            return  new DoctorUpdateVM()
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Specialization = doctor.Specialization,
                Salary = doctor.Salary,
            };
            
        }
        public void AddDoctorVM(DoctorAddVM doctorVM)
        {
            Doctor doctor = new Doctor()
            {
                Id = Guid.NewGuid(),
                Name = doctorVM.Name,
                Specialization = doctorVM.Specialization,
                Salary = doctorVM.Salary,
                PerofrmancRate = doctorVM.PerofrmancRate,
            };
            unitOfWork.DoctorRepo.Add(doctor);
            unitOfWork.Savechanges();
        }
        public void UpdateDoctorVM(DoctorUpdateVM doctorVM)
        {
            Doctor? doctor = unitOfWork.DoctorRepo.GetById(doctorVM.Id);
            if (doctor is null)
            {
                return;
            }

            doctor.Name = doctorVM.Name;
            doctor.Specialization = doctorVM.Specialization;
            doctor.Salary = doctorVM.Salary;


            unitOfWork.DoctorRepo.Update(doctor);
            unitOfWork.Savechanges();
        }
        public void DeleteDoctorVM(Guid id)
        {
            Doctor? doctor = unitOfWork.DoctorRepo.GetById(id); 
            if(doctor is null) { return; }
            unitOfWork.DoctorRepo.Delete(doctor);
            unitOfWork.Savechanges();
        }

        public DoctorDetailsVM? GetDoctorDetailsByID(Guid id)
        {
            Doctor? doctor = unitOfWork.DoctorRepo.GetByIdWithPatientsAndIssues(id);
            if (doctor is null) 
            {
                return null; 
            }
            return new DoctorDetailsVM
            {
                Name = doctor.Name,
                Specialization = doctor.Specialization,
                PerofrmancRate = doctor.PerofrmancRate,
                Patients = doctor.Patients.Select(p => new PatientChildVM()
                {
                    Name = p.Name,
                    NumberOfIssues = p.Issues.Count
                }).ToList()
            };
        }

        public DoctorDeleteVM? GetDoctorByIDToDelete(Guid id)
        {
            Doctor? doctorfromdb = unitOfWork.DoctorRepo.GetById(id);
            if (doctorfromdb is null)
            {
                return null;
            }

            DoctorDeleteVM doctorDeleteVM = new DoctorDeleteVM
            {
                Id = doctorfromdb.Id,
                Name = doctorfromdb.Name,
                Specialization = doctorfromdb.Specialization,
                Salary = doctorfromdb.Salary,
                PerofrmancRate = doctorfromdb.PerofrmancRate
            };
            return doctorDeleteVM;
        }
    }
}
