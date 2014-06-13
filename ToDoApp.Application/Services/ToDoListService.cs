using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.Services
{
    public class ToDoListService
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IUserRepository _userRepository;

        public ToDoListService(IToDoListRepository toDoListRepository, IUserRepository userRepository)
        {
            _toDoListRepository = toDoListRepository;
            _userRepository = userRepository;
        }

        
        public ToDoList Details(int toDoListId)
        {
            var result = _toDoListRepository.Get(toDoListId, ToDoListDependencies.ToDoItems);
            result.Owner = _userRepository.Get(result.UserId);
            return result;
        }
    }
}