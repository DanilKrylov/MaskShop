using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.DataBase;
using MaskShop.Services.ServiceInterfaces;
using MaskShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaskShop.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserRepositoryService _userRepositoryService;
        public RegistrationController(IUserRepositoryService userRepositoryService)
        {
            _userRepositoryService = userRepositoryService;
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel registrationViewModel)
        {
            if (_userRepositoryService.UserIsRegistered(registrationViewModel.Login))
            {
                ModelState.AddModelError("Login", "Данный логин уже занят");
            }
            if (!ModelState.IsValid)
            {
                return View(registrationViewModel);
            }

            ControllerContext.HttpContext.Session.SetString("login", registrationViewModel.Login);
            _userRepositoryService.AddUser(registrationViewModel);

            return RedirectPermanent("~/Home/Index");
        }
    }
}
