using System.Collections.Generic;
using System.Linq;
using Dapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Data.Repositories
{
    public class ToDoListRepository : Repository<ToDoList>, IToDoListRepository
    {
        private readonly IToDoItemRepository _toDoItemRepository;

        public ToDoListRepository(IToDoItemRepository toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }


        public ToDoList Get(int id, ToDoListDependencies dependencies)
        {
            var result = Get(id);
            GetDependencies(result, dependencies);
            return result;
        }

        public List<ToDoList> GetListForUser(int userId, ToDoListDependencies dependencies)
        {
            var sql = @"
SELECT * FROM ToDoLists
WHERE UserId = @userId";
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                var result = conn.Query<ToDoList>(sql, new { userId }).ToList();
                GetDependencies(result, dependencies);
                return result;
            }
        }


        private void GetDependencies(ToDoList toDoList, ToDoListDependencies dependencies)
        {
            if ((dependencies & ToDoListDependencies.ToDoItems) == ToDoListDependencies.ToDoItems)
            {
                toDoList.ToDoItems = _toDoItemRepository.GetListForList(toDoList.Id);
            }
        }

        private void GetDependencies(List<ToDoList> toDoLists, ToDoListDependencies dependencies)
        {
            if ((dependencies & ToDoListDependencies.ToDoItems) == ToDoListDependencies.ToDoItems)
            {
                var toDoItems = _toDoItemRepository.GetListForLists(toDoLists.Select(l => l.Id).ToList());
                foreach (var toDoList in toDoLists)
                {
                    toDoList.ToDoItems = toDoItems.Where(i => i.ToDoListId == toDoList.Id);    
                }
            }
        }
    }
}