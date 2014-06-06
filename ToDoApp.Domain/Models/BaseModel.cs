using System;

namespace ToDoApp.Domain.Models
{
    public abstract class BaseModel
    {
        public virtual int Id { get; protected set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual bool IsValid
        {
            get { return true; }
        }

        public virtual bool CanModify(User user)
        {
            return true;
        }
    }
}