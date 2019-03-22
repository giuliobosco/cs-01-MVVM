﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _06_Amici.DA.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _06_Amici.MVC.Controllers {
    public class AmiciController : Controller {

        private IAmicoRepository ctx;

        public AmiciController() {
            ctx = new MockAmicoRepository();
        }

        // GET: /<controller>/
        public IActionResult Index() {
            return View(ctx.Get());
        }
    }
}