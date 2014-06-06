using System.Web.Http;
using ToDoApp.Application.Services;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Controllers
{
    public class ListsController : ApiController
    {
        private readonly IToDoListService _toDoListService;

        public ListsController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }


        /// <summary>
        /// Get a list with its to do items.
        /// </summary>
        public ToDoList Get(int id)
        {
            return _toDoListService.Get(id);
        }
    }
}
