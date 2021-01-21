using Microsoft.AspNetCore.Mvc;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _productRepo;

        public HomeController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            var prd = _productRepo.GetAllProduct();
            return View(prd);
        }
    }

}
