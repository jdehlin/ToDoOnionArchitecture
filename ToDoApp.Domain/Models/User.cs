using System;
using System.Collections.Generic;

namespace ToDoApp.Domain.Models
{
    public class User : DataTransfer.User
    {
        public User() { }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        
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