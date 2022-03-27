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
    public class ClientController : Controller
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var client = await _service.GetAll();
            return View(client);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,Mobile,Email,Company")]Client client)
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
