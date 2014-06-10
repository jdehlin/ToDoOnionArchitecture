using System.Collections.Generic;
using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.DataTransfer;
using User = ToDoApp.Domain.Models.User;

namespace ToDoApp.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<User> GetAll()
        {
            var result = _userRepository.GetList();
            var mappedResult = Mapper.Map<List<Domain.DataTransfer.User>, List<User>>(result);
            return mappedResult;
        }

        public User GetWithLists(int userId)
        {
            var result = _userRepository.Get(userId, UserDependencies.ToDoLists);
            var mappedResult = Mapper.Map<Domain.DataTransfer.User, User>(result);
            return mappedResult;
        }
    }
}