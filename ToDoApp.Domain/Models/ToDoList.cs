using System;
using System.Collections.Generic;

namespace ToDoApp.Domain.Models
{
    public sealed class ToDoList : DataTransfer.ToDoList
    {
        public ToDoList(int id, int userId, string title)
        {
            Id = id;
            UserId = userId;
            Title = title;

            CreatedAt = DateTime.Now;
        }

        
        public List<ToDoItem> ToDoItems { get; set; }

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