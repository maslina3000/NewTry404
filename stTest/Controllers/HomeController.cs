using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stTest.Models;
using Microsoft.EntityFrameworkCore;

namespace stTest.Controllers
{
    public class HomeController : Controller
    {
        private AnswerContext db;
        public HomeController(AnswerContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Answers.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Answer answer)
        {
            db.Answers.Add(answer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
