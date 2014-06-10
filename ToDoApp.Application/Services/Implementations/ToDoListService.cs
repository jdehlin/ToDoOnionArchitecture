using AutoMapper;
using ToDoApp.Application.DataInterfaces;
using ToDoApp.Domain.DataTransfer;
using ToDoList = ToDoApp.Domain.Models.ToDoList;

namespace ToDoApp.Application.Services.Implementations
{
    public class ToDoListService : IToDoListService
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListService(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }


        public ToDoList Get(int toDoListId)
        {
            var result = _toDoListRepository.Get(toDoListId);
            var mappedResult = Mapper.Map<Domain.DataTransfer.ToDoList, ToDoList>(result);
            return mappedResult;
        }

        public ToDoList GetWithItems(int toDoListId)
        {
            var result = _toDoListRepository.Get(toDoListId, ToDoListDependencies.ToDoItems);
            var mappedResult = Mapper.Map<Domain.DataTransfer.ToDoList, ToDoList>(result);
            return mappedResult;
        }
    }
}