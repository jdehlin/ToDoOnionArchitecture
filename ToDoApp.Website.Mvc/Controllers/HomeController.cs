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
        private readonly UserService _userService;

        public HomeController(UserService userService)
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