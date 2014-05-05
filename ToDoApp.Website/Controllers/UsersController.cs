using System.Collections.Generic;
using System.Web.Http;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Controllers
{
    public class UsersController : ApiController
    {
        /// <summary>
        /// Get a list of all of the users.
        /// </summary>
        public List<User> Get()
        {
            return new List<User> { new User(1, "John Jones") };
        }

        /// <summary>
        /// Get a user with its to do lists.
        /// </summary>
        public User Get(int id)
        {
            return new User(1, "John Jones") { ToDoLists = new List<ToDoList> { new ToDoList(1, 1, "Things To Do") } };
        }
    }
}
