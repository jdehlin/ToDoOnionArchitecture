using AutoMapper;
using ToDoApp.Domain.DataTransfer;
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
            Mapper.CreateMap<ViewToDoList, ToDoList>();
            Mapper.CreateMap<ToDoList, ViewToDoList>();
        }
    }
}