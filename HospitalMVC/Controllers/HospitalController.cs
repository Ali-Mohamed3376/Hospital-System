using Hospital.BL.Manager.Doctors;
using Hospital.BL.ViewModels.Doctors;
using Hospital.DAL.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMVC.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IDoctorManager _manager;

        public HospitalController(IDoctorManager manager)
        {
            _manager = manager;
        }

        #region Get All Doctors
        [HttpGet]
        public IActionResult Index()
        {
            var doctors = _manager.GetDoctorVMs();
            return View(doctors);
        } 
        #endregion

        #region Add Doctor
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(DoctorAddVM doctorAddVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _manager.AddDoctorVM(doctorAddVM);
            TempData[ToasterMessage.Operation] = ToasterMessage.Add;
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Update Doctor
        [HttpGet]
        public IActionResult Update(Guid id)
        {
            DoctorUpdateVM? doctorUpdateVM = _manager.GetDoctorUpdateVMById(id);
            if ( doctorUpdateVM is null) { return View(); }
            return View(doctorUpdateVM);
        }
        [HttpPost]
        public IActionResult Update(DoctorUpdateVM doctorUpdateVM)
        {
            _manager.UpdateDoctorVM(doctorUpdateVM);
            TempData[ToasterMessage.Operation] = ToasterMessage.Update;
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region DetailsVM
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            DoctorDetailsVM? doctor = _manager.GetDoctorDetailsByID(id);
            return View(doctor);
        }
        #endregion

        #region DeleteVM
        //[HttpGet]
        //public IActionResult Delete(Guid id)
        //{
        //    DoctorDeleteVM? doctor = _context.GetDoctorByIDToDelete(id);
        //    if (doctor is null)
        //    {
        //        return null;
        //    }
        //    return View(doctor);
        //}

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _manager.DeleteDoctorVM(id);
            TempData[ToasterMessage.Operation] = ToasterMessage.Delete;
            return RedirectToAction(nameof(Index));
        }
        #endregion

       
    }
}
