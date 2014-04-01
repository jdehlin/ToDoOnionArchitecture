using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ToDoApp.Website.Controllers
{
    public class PartialsController : Controller
    {
        //
        // GET: /UsersList/

        public ActionResult UsersList()
        {
            return View();
        }

        //
        // GET: /ToDoLists/

        public ActionResult ToDoLists()
        {
            return View();
        }
    }
}
