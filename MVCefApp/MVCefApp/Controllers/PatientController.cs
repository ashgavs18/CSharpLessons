using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCefApp.Models;

namespace MVCefApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: DoctorControll
        public ActionResult Index()
        {
            List<Patient> patient = PatientRepository.GetPatient();
            if (patient != null && patient.Count > 0)
                return View(patient);
            else
                return RedirectToAction("Create");
        }

        // GET: PatientController/Details/5
        // GET: DoctorControll/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = PatientRepository.GetPatientById(id);
            return View(patient);
        }

        // GET: PatientController/Create
        
        public ActionResult Create()
        {

            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Patient pPatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PatientRepository.AddNewPatient(pPatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception error)
            {
                return View(error);
            }
        }


        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = PatientRepository.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        
        public ActionResult Edit(IFormCollection collection, Patient pPatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PatientRepository.ModifyPatient(pPatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception error)
            {
                return View(error);
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = PatientRepository.GetPatientById(id);
            return View(patient);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PatientRepository.RemovePatient(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
