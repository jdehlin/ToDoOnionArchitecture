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

        //
        // GET: /ToDoList/
        public ActionResult ToDoList()
        {
            return View();
        }
    }
}
