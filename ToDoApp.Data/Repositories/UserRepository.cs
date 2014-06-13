using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IToDoListRepository _toDoListRepository;

        public UserRepository(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }


        public User Get(int id, UserDependencies dependencies)
        {
            var user = Get(id);
            if (user != null) GetDependencies(user, dependencies);
            return user;
        }


        private void GetDependencies(User user, UserDependencies dependencies)
        {
            if ((dependencies & UserDependencies.ToDoLists) == UserDependencies.ToDoLists)
            {
                user.ToDoLists = _toDoListRepository.GetListForUser(user.Id, ToDoListDependencies.None);
            }
        }
    }
}