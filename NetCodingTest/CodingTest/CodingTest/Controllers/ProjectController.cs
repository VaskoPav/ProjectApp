using CodingTest.DataAccess;
using CodingTest.Models.Models;
using CodingTest.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _service;
        public ProjectController(IProjectService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var project = await _service.GetAll();
            return View(project);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("NameProject,StartDate,EndDate")] Project project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }
            _service.Add(project);
            return RedirectToAction(nameof(Index));
        }
    }
}
