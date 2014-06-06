using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

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
            return _userRepository.GetList();
        }

        public User GetWithLists(int userId)
        {
            var result = _userRepository.Get(userId);
            var mappedResult = Mapper.Map<Domain.DataTransfer.User, User>(result);
            return mappedResult;
        }
    }
}