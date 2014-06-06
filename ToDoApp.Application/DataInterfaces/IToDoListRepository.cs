using System.Collections.Generic;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IToDoListRepository : IRepository<ToDoList>
    {
        List<ToDoList> GetListForUser(int userId);
    }
}