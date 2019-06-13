using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practive_shop.Models;
using Practive_shop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practive_shop.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPieRespository _pieRespository;

        public HomeController(IPieRespository pieRespository)
        {
            _pieRespository = pieRespository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var pies = _pieRespository.GetAllPie().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Khanh Van's Pie Shop",
                Pies = pies.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Detail(int id)
        {
            var pie = _pieRespository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
