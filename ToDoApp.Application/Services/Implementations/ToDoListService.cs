using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.Models;

namespace ToDoApp.Application.Services.Implementations
{
    public class ToDoListService : IToDoListService
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListService(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }


        public ToDoList Get(int listId)
        {
            var result = _toDoListRepository.Get(listId);
            var mappedResult = Mapper.Map<Domain.DataTransfer.ToDoList, ToDoList>(result);
            return mappedResult;
        }
    }
}