﻿using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("user/add")]
        public IActionResult Add()
        {
            return View();
        }

        

        [HttpPost]
        [Route("user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (verify == newUser.Password)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again.";
                ViewBag.userName = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}    
