using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.DataTransfer;

namespace ToDoApp.Data.Repositories
{
    public class ToDoItemRepository : Repository<ToDoItem>, IToDoItemRepository
    {
         
    }
}