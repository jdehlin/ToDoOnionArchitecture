using System.Collections.Generic;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IToDoItemRepository : IRepository<ToDoItem>
    {
        List<ToDoItem> GetListForList(int toDoListId);
        List<ToDoItem> GetListForLists(List<int> toDoListsId);
    }
}