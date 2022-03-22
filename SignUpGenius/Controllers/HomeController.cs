﻿using Microsoft.AspNetCore.Mvc;
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

        public HomeController(IAppointmentRepository temp)
        {
           repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            //Determine the number of Books on a page
            int pageSize = 10;

            var x = new ToursViewModel
            {
                Appointments = repo.Appointments
                //.Where(a => a.AppointmentTime >= tourTime || tourTime == null) //Helps sort by day when selected by user
                .OrderBy(a => a.AppointmentTime) // Orders all displayed Books in alphabetical order
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                TourInfo = new TourInfo
                {
                    //Gets inmportant Book info - If no category gets info for all books, other wise info is filtered by the selected category
                    TotalNumTours = repo.Appointments.Count(), //( == null ? repo.Books.Count() : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    ToursPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

        public IActionResult SignUpTimes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpForm()
        {
            return View(new Appointment());
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment appointment)
        {
            repo.SaveAppointment(appointment);
            return RedirectToPage("/Index");
        }
    }
}
