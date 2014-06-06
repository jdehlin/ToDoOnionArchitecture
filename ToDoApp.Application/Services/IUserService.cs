using System.Collections.Generic;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.Services
{
    public interface IUserService
    {
        List<User> Get();
        User Get(int userId);
    }
}