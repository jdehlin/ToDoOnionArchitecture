using System;

namespace ToDoApp.Domain.Models
{
    public sealed class ToDoItem : BaseModel
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

            CreatedAt = DateTime.Now;
        }


        public int UserId { get; private set; }

        public string Body { get; private set; }

        public ToDoItemStatus Status { get; set; }
        
        public DateTime? UpdatedAt { get; set; }

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