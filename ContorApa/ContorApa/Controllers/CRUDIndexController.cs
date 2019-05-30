using ContorApa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContorApa.Controllers
{
    public class CRUDIndexController : Controller
    {
        private readonly ICRUDIndexRepository _crudIndexRepository;

        public CRUDIndexController(ICRUDIndexRepository crudIndexRepository)
        {
            _crudIndexRepository = crudIndexRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddIndex(ContorIndex contorIndex)
        {
            if (ModelState.IsValid)
            {
                _crudIndexRepository.AddIndex(contorIndex);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult UpdateIndex(ContorIndex contorIndex)
        {
            if (ModelState.IsValid)
            {
                _crudIndexRepository.UpdateIndex(contorIndex);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult DeleteIndex(ContorIndex contorIndex)
        {
            if (ModelState.IsValid)
            {
                _crudIndexRepository.DeleteIndex(contorIndex);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
