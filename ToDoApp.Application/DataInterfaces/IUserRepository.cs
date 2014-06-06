using ToDoApp.Domain.Models;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(int id, UserDependencies dependencies);
    }
}