using System;

namespace ToDoApp.Domain.Models
{
    public sealed class ToDoItem : DataTransfer.ToDoItem
    {
        public enum ToDoItemStatus
        {
            InProgress = 1,
            Completed = 2
        }

        public ToDoItem(int id, int userId, string body)
        {
            Id = id;
            UserId = userId;
            Body = body;

            Status = ToDoItemStatus.InProgress;

            CreatedAt = DateTime.Now;
        }

        
        public override bool IsValid
        {
            get
            {
                var userIdSet = UserId > 0;
                var validBody = Body.Length > 3 && Body.Length <= 100;
                return userIdSet && validBody;
            }
        }

        public override bool CanModify(User user)
        {
            return IsValid && UserId == user.Id;
        }
    }
}