using System.Collections.Generic;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IList<T> GetList();

        int Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}