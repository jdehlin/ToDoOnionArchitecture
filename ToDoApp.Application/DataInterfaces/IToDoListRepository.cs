using System.Collections.Generic;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IToDoListRepository : IRepository<ToDoList>
    {
        ToDoList Get(int id, ToDoListDependencies dependencies);
        List<ToDoList> GetListForUser(int userId, ToDoListDependencies dependencies);
    }
}