using System;
using ToDoApp.Domain.Models;

namespace ToDoApp.Domain
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