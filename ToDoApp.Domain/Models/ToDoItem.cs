using System;

namespace ToDoApp.Domain.Models
{
    public class ToDoItem : BaseModel
    {
        public enum ToDoItemStatus
        {
            InProgress = 1,
            Completed = 2
        }

        public ToDoItem(int id, int toDoListId, string body)
        {
            Id = id;
            ToDoListId = toDoListId;
            Body = body;

            Status = ToDoItemStatus.InProgress;

            CreatedAt = DateTime.Now;
        }


        public int Id { get; private set; }
        public int ToDoListId { get; private set; }
        public string Body { get; set; }
        public ToDoItemStatus Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public override bool IsValid
        {
            get
            {
                var toDoListIdSet = ToDoListId > 0;
                var validBody = Body.Length > 3 && Body.Length <= 100;
                return toDoListIdSet && validBody;
            }
        }

        public override bool CanModify(User user)
        {
            throw new NotImplementedException("Need the ToDoList as well.");
        }

        public bool CanModify(User user, ToDoList toDoList)
        {
            return IsValid && BelongsToList(toDoList) && toDoList.CanModify(user);
        }

        public bool BelongsToList(ToDoList toDoList)
        {
            return toDoList.Id == ToDoListId;
        }
    }
}