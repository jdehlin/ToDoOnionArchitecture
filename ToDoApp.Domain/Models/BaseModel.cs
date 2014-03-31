using System;

namespace ToDoApp.Domain.Models
{
    public abstract class BaseModel
    {
        public virtual int Id { get; protected set; }

        public virtual DateTime CreatedAt { get; set; }

        public abstract bool IsValid { get; }

        public abstract bool CanModify(User user);
    }
}