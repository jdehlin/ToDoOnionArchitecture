using System;
using System.Collections.Generic;

namespace ToDoApp.Domain.Models
{
    [Flags]
    public enum ToDoListDependencies
    {
        None = -1,
        ToDoItems = 1
    }

    public class ToDoList : BaseModel
    {
        public ToDoList(int id, int userId, string title)
        {
            Id = id;
            UserId = userId;
            Title = title;

            CreatedAt = DateTime.Now;
        }


        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<ToDoItem> ToDoItems { get; set; }
        public User Owner { get; set; }


        public override bool IsValid
        {
            get
            {
                var userIdSet = UserId > 0;
                var validBody = Title.Length > 3 && Title.Length <= 100;
                return userIdSet && validBody;
            }
        }

        public override bool CanModify(User user)
        {
            return IsValid && Id == user.Id;
        }
    }
}