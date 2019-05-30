using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContorApa.Models;
using ContorApa.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContorApa.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContorIndexRepository _contorIndexRepository;

        public HomeController(IContorIndexRepository contorIndexRepository)
        {
            _contorIndexRepository = contorIndexRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var contorIndexes = _contorIndexRepository.GetAllIndexes().OrderBy(p => p.Id);
            var homeViewModel = new HomeViewModel()
            {
                ContorIndexes = contorIndexes.ToList(),
                TotalCold = _contorIndexRepository.GetTotalColdIndex(),
                TotalHot = _contorIndexRepository.GetTotalHotIndex()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var contorIndexes = _contorIndexRepository.GetContorIndexById(id);
            if (contorIndexes == null) return NotFound();

            return View(contorIndexes);
        }
    }
}