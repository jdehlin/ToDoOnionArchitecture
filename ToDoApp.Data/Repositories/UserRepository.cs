using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.DataTransfer;

namespace ToDoApp.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        
    }
}