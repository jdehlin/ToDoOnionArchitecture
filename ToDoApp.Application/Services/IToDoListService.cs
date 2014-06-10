using System.Collections.Generic;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.Services
{
    public interface IToDoListService
    {
        ToDoList Get(int toDoListId);
        ToDoList GetWithItems(int toDoListId);
    }
}