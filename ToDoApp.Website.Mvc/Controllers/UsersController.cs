﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ToDoApp.Application.Services;
using ToDoApp.Domain.DataTransfer;
using ToDoApp.Website.Mvc.ViewModels;

namespace ToDoApp.Website.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: /Users
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        // GET: /Users/Details/5
        public ActionResult Details(int id)
        {
            var result = _userService.GetWithLists(id);
            var mappedResult = Mapper.Map<User, ViewUser>(result);
            return View(mappedResult);
        }
    }
}