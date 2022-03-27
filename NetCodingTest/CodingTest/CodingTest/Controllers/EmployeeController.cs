using CodingTest.DataAccess;
using CodingTest.Models.Models;
using CodingTest.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _service;

        public EmployeeController(IEmployee service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,MobilePhone,Email,EmployeeNum")] Employee client)
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }
            _service.Add(client);
            return RedirectToAction(nameof(Index));
        }
    }
}
