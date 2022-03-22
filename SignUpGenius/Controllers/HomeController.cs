using Microsoft.AspNetCore.Mvc;
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

            return View();
        }

        public IActionResult Appointments()
        {

            var x = new AppointmentViewModel
            {
                Appointments = repo.Appointments
                //.Where(a => a.AppointmentTime >= tourTime || tourTime == null) //Helps sort by day when selected by user
                .OrderBy(a => a.Time) // Orders all displayed Books in alphabetical order
                //.Skip((pageNum - 1) * pageSize)
                //.Take(pageSize),

                //TourInfo = new AppointmentInfo
                //{
                //    //Gets inmportant Book info - If no category gets info for all books, other wise info is filtered by the selected category
                //    TotalNumTours = repo.Appointments.Count(), //( == null ? repo.Books.Count() : repo.Books.Where(x => x.Category == bookCategory).Count()),
                //    ToursPerPage = pageSize,
                //    CurrentPage = pageNum
                //}
            };

            return View(x);
        }
    }
}
