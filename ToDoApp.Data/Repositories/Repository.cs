using System.Collections.Generic;
using System.Linq;
using Dapper;
using ToDoApp.Application.DataInterfaces;

namespace ToDoApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public T Get(int id)
        {
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                conn.Open();
                var result = conn.Get<T>(id);
                return result;
            }
        }

        public List<T> GetList()
        {
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                conn.Open();
                var result = conn.GetList<T>().ToList();
                return result;
            }
        }

        public int Insert(T entity)
        {
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                conn.Open();
                var result = conn.Insert(entity);
                return result.Value;
            }
        }

        public void Update(T entity)
        {
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                conn.Open();
                conn.Update(entity);
            }
        }

        public void Delete(T entity)
        {
            using (var conn = DbUtilities.GetProfiledConnection(DbUtilities.ConnectionString()))
            {
                conn.Open();
                conn.Delete(entity);
            }
        }
    }
}