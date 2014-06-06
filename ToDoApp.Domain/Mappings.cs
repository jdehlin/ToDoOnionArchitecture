using AutoMapper;
using ToDoApp.Domain.Models;

namespace ToDoApp.Domain
{
    public static class Mappings
    {
        public static void Initialize()
        {
            // define mappings
            Mapper.CreateMap<DataTransfer.User, User>();
            Mapper.CreateMap<User, DataTransfer.User>();
        } 
    }
}