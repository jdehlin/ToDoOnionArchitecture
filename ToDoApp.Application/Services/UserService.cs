using System.Collections.Generic;
using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<User> List()
        {
            var result = _userRepository.GetList();
            return result;
        }

        public User Details(int userId)
        {
            var temp = new User(1, "test");

            var result = _userRepository.Get(userId, UserDependencies.ToDoLists);
            return result;
        }
    }
}