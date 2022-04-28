using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaskShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMaskRepositoryService _maskRepository;
        public HomeController(IMaskRepositoryService maskRepository)
        {
            _maskRepository = maskRepository;
        }
        public IActionResult Index()
        {
            ViewBag.UserName = ControllerContext.HttpContext.Session.GetString("name");
            var masks = _maskRepository.GetMasksInRange(0, 10).ToList();

            return View(masks);
        }
        [HttpPost]
        public ViewResult GetAdditionalMasks(int from, int count)
        {
            var masks = _maskRepository.GetMasksInRange(from, count).ToList();
            return View(masks);
        }
    }
}
