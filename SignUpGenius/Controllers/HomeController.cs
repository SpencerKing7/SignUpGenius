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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUpTimes()
        {
            return View();
        }

        public IActionResult SignUpForm()
        {
            return View();
        }

        public IActionResult Appointments(int pageNum = 1)
        {
            //Determine the number of Books on a page
            int pageSize = 10;

            var x = new AppointmentViewModel
            {
                Appointments = repo.Appointments
                //.Where(a => a.AppointmentTime >= tourTime || tourTime == null) //Helps sort by day when selected by user
                .OrderBy(a => a.Time) // Orders all displayed Books in alphabetical order
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                TourInfo = new AppointmentInfo
                {
                    //Gets inmportant Book info - If no category gets info for all books, other wise info is filtered by the selected category
                    TotalNumTours = repo.Appointments.Count(), //( == null ? repo.Books.Count() : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    ToursPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
