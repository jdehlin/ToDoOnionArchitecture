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

        public ToDoItem(int id, int toDoListId, string body)
        {
            Id = id;
            ToDoListId = toDoListId;
            Body = body;

            Status = ToDoItemStatus.InProgress;

            CreatedAt = DateTime.Now;
        }

        
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