using System.Web.Mvc;
using AutoMapper;
using ToDoApp.Application.Services;
using ToDoApp.Domain.Models;
using ToDoApp.Website.Mvc.ViewModels;

namespace ToDoApp.Website.Mvc.Controllers
{
    public class ListsController : Controller
    {
        private readonly ToDoListService _toDoListService;

        public ListsController(ToDoListService tsDoListService)
        {
            _toDoListService = tsDoListService;
        }


        // GET: /Lists/Details/5
        public ActionResult Details(int id)
        {
            var result = _toDoListService.Details(id);
            var mappedResult = Mapper.Map<ToDoList, ViewToDoList>(result);
            return View(mappedResult);
        }
    }
}