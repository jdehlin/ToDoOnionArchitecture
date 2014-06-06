using System.Collections.Generic;
using System.Linq;
using Dapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Data.Repositories
{
    public class ToDoListRepository : Repository<ToDoList>, IToDoListRepository
    {
        public List<ToDoList> GetListForUser(int userId)
        {
            var sql = @"
SELECT * FROM ToDoLists
WHERE UserId = @userId";
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                return conn.Query<ToDoList>(sql, userId).ToList();
            }
        }
    }
}