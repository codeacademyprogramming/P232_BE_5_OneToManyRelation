using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniversityApp.DAL;
using UniversityApp.Models;
using UniversityApp.ViewModels;

namespace UniversityApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityDbContext _context;

        public StudentController(UniversityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            StudentViewModel vm = new StudentViewModel
            {
                Students = _context.Students.Include(x=>x.Group).ToList(),
                Groups = _context.Groups.Include(x=>x.Students).ToList()
            };

            return View(vm);
        }
    }
}
