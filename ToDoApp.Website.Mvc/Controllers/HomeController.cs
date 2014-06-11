using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ToDoApp.Application.Services;
using ToDoApp.Domain.Models;
using ToDoApp.Website.Mvc.ViewModels;

namespace ToDoApp.Website.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }


        public ActionResult Index()
        {
            var result = _userService.GetAll();
            var mappedResult = Mapper.Map<List<User>, List<ViewUser>>(result);
            return View(mappedResult);
        }
    }
}