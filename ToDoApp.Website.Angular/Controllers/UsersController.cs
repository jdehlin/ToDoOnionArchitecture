using System.Collections.Generic;
using System.Web.Http;
using ToDoApp.Application.Services;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Controllers
{
    public class UsersController : ApiController
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }


        /// <summary>
        /// Get a list of all of the users.
        /// </summary>
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        /// <summary>
        /// Get a user with its to do lists.
        /// </summary>
        public User Get(int id)
        {
            return _userService.GetWithLists(id);
        }
    }
}
