using buoi3lab456.Models;
using buoi3lab456.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace buoi3lab456.Controllers
{
    public class CoureseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoureseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
        // GET: Courese
}