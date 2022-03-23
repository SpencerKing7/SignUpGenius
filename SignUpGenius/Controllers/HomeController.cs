using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SignUpGenius.Models;
using SignUpGenius.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Controllers
{
    public class HomeController : Controller
    {
        private IAppointmentRepository repo;
        private ITimeRepository repoT;

        public HomeController(IAppointmentRepository temp, ITimeRepository tempT)
        {
            repo = temp;
            repoT = tempT;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpTimes(string time, int pageNum = 1)
        {
            ViewBag.AppointmentTimes = repoT.AppointmentTimes.ToList();

            int pageSize = 12;

            var x = new TimeViewModel
            {
                Times = repoT.AppointmentTimes
                .Where(x => x.Time == time || time == null)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                TimeInfo = new TimeInfo
                {
                    TotalNumTours = (time == null 
                        ? repoT.AppointmentTimes.Count()
                        : repoT.AppointmentTimes.Where(x => x.Time == time).Count()),

                    ToursPerPage = pageSize,

                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

        [HttpGet]
        public IActionResult SignUpForm(int id)
        {
            ViewBag.Time = repoT.AppointmentTimes.Single(t => t.TimeId == id);

            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment a)
        {
            var x = repoT.AppointmentTimes
                .Single(t => (t.Time == a.Time && t.Date == a.Date));

            x.Available = false;

            repoT.SaveTime(x);

            repo.CreateAppointment(a);

            return RedirectToAction("Index");
        }

        public IActionResult Appointments()
        {

            var x = new AppointmentViewModel
            {
                Appointments = repo.Appointments
                .OrderBy(a => a.Time) // Orders all displayed Books in alphabetical order
            };

            return View(x);
        }

        [HttpGet]
        public IActionResult EditForm(int aptId)
        {
            var appointment = repo.Appointments.Single(x => x.AppointmentId == aptId);

            return View("EditForm", appointment);
        }

        [HttpPost]
        public IActionResult EditForm(Appointment a)
        {
            repo.SaveAppointment(a);

            return RedirectToAction("Appointments");
        }

        [HttpGet]
        public IActionResult DeletePage(int aptId)
        {
            var appointment = repo.Appointments.Single(x => x.AppointmentId == aptId);

            return View("Delete", appointment);
        }

        [HttpPost]
        public IActionResult Delete(Appointment a)
        {
            var apt = repo.Appointments.Single(x => x.AppointmentId == a.AppointmentId);

            var x = repoT.AppointmentTimes
                .Single(t => (t.Time == apt.Time && t.Date == apt.Date));

            x.Available = true;

            repoT.SaveTime(x);

            repo.DeleteAppointment(apt);

            return RedirectToAction("Appointments");
        }

        //[HttpGet]
        //public IActionResult Delete(int aptid)
        //{
        //    repo.DeleteAppointment(x => aptid);

        //    return RedirectToAction("Index");
        //}
    }
}
