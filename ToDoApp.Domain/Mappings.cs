using AutoMapper;
using ToDoApp.Domain.Models;

namespace ToDoApp.Domain
{
    public static class Mappings
    {
        public static void Initialize()
        {
            Mapper.CreateMap<DataTransfer.User, User>();
            Mapper.CreateMap<User, DataTransfer.User>();
            Mapper.CreateMap<DataTransfer.ToDoList, ToDoList>();
            Mapper.CreateMap<ToDoList, DataTransfer.ToDoList>();
            Mapper.CreateMap<DataTransfer.ToDoItem, ToDoItem>();
            Mapper.CreateMap<ToDoItem, DataTransfer.ToDoItem>();
        } 
    }
}