using System.Collections.Generic;
using System.Linq;
using Dapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.DataTransfer;

namespace ToDoApp.Data.Repositories
{
    public class ToDoItemRepository : Repository<ToDoItem>, IToDoItemRepository
    {
        public List<ToDoItem> GetListForList(int toDoListId)
        {
            var sql = @"
SELECT * FROM ToDoItems
WHERE ToDoListId = @toDoListId";
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                return conn.Query<ToDoItem>(sql, new {toDoListId}).ToList();
            }
        }

        public List<ToDoItem> GetListForLists(List<int> toDoListIds)
        {
            var sql = @"
SELECT * FROM ToDoItems
WHERE ToDoListId IN (@toDoListIds)";
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                return conn.Query<ToDoItem>(sql, new { toDoListIds }).ToList();
            }
        }
    }
}