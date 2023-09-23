using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCefApp.Models;

namespace MVCefApp.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appointment> appointment = AppointmentRepository.GetAppointment();
            if (appointment != null && appointment.Count > 0)
                return View(appointment);
            else
                return RedirectToAction("Create");
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            Appointment appointment = AppointmentRepository.GetAppointmentById(id);
            return View(appointment);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Appointment pAppointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AppointmentRepository.AddNewAppointment(pAppointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception error)
            {
                return View(error);
            }
        }

            // GET: AppointmentController/Edit/5
            public ActionResult Edit(int id)
        {

            Appointment appointment = AppointmentRepository.GetAppointmentById(id);
            return View(appointment);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public ActionResult Edit(IFormCollection collection, Appointment pAppointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AppointmentRepository.ModifyAppointments(pAppointment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception error)
            {
                return View(error);
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            Appointment appointment = AppointmentRepository.GetAppointmentById(id);
            return View(appointment);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    AppointmentRepository.RemoveAppointment(id);
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
