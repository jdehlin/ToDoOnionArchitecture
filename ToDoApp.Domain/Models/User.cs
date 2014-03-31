using System.Collections.Generic;

namespace ToDoApp.Domain.Models
{
    public sealed class User : BaseModel
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        

        public string Name { get; private set; }

        public List<ToDoList> ToDoLists { get; set; }

        public override bool IsValid
        {
            get { return true; }
        }

        public override bool CanModify(User user)
        {
            return IsValid && Id == user.Id;
        }
    }
}