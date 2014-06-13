using AutoMapper;
using ToDoApp.Domain.Models;
using ToDoApp.Website.Mvc.ViewModels;

namespace ToDoApp.Website.Mvc
{
    public class AutoMapperConfig
    {
        public static void CreateMappings()
        {
            Domain.Mappings.Initialize();

            Mapper.CreateMap<User, ViewUser>();
            Mapper.CreateMap<ViewUser, User>();
            Mapper.CreateMap<ToDoList, ViewToDoList>();
            Mapper.CreateMap<ViewToDoList, ToDoList>();
            Mapper.CreateMap<ToDoItem, ViewToDoItem>();
            Mapper.CreateMap<ViewToDoItem, ToDoItem>();
        }
    }
}