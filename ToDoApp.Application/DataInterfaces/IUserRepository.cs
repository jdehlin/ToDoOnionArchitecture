using ToDoApp.Domain.DataTransfer;

namespace ToDoApp.Application.DataInterfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(int id, UserDependencies dependencies);
    }
}