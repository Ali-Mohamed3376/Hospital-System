using Hospital.BL.ViewModels.Doctors;
namespace Hospital.BL.Manager.Doctors
{
    public interface IDoctorManager
    {
        IEnumerable<DoctorVM> GetDoctorVMs();
        DoctorVM? GetByID(Guid id);
        DoctorUpdateVM? GetDoctorUpdateVMById(Guid id);
        void AddDoctorVM(DoctorAddVM doctorVM);
        void UpdateDoctorVM(DoctorUpdateVM doctorVM);
        DoctorDetailsVM? GetDoctorDetailsByID(Guid id);
        void DeleteDoctorVM(Guid id);
        DoctorDeleteVM? GetDoctorByIDToDelete(Guid id);
    }
}
