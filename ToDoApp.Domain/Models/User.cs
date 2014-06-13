using System;
using System.Collections.Generic;

namespace ToDoApp.Domain.Models
{
    [Flags]
    public enum UserDependencies
    {
        None = -1,
        ToDoLists = 1
    }

    public class User : BaseModel
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public int Id { get; private set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<ToDoList> ToDoLists { get; set; }


        public override bool IsValid
        {
            get { return !string.IsNullOrWhiteSpace(Name) && Name.Length > 3 && Name.Length < 50; }
        }

        public override bool CanModify(User user)
        {
            return IsValid && Id == user.Id;
        }
    }
}