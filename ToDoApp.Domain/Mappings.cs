using AutoMapper;
using ToDoApp.Domain.Models;

namespace ToDoApp.Domain
{
    public static class Mappings
    {
        public static void Initialize()
        {
            Mapper.CreateMap<DataTransfer.User, User>().ConstructUsing(u => new User(u.Id, u.Name));
            Mapper.CreateMap<User, DataTransfer.User>();
            Mapper.CreateMap<DataTransfer.ToDoList, ToDoList>().ConstructUsing(l => new ToDoList(l.Id, l.UserId, l.Title));
            Mapper.CreateMap<ToDoList, DataTransfer.ToDoList>();
            Mapper.CreateMap<DataTransfer.ToDoItem, ToDoItem>().ConstructUsing(l => new ToDoItem(l.Id, l.ToDoListId, l.Body));
            Mapper.CreateMap<ToDoItem, DataTransfer.ToDoItem>();
        } 
    }
}