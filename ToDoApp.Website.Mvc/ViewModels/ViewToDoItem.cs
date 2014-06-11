using System;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Mvc.ViewModels
{
    public class ViewToDoItem
    {
        public virtual int Id { get; set; }
        
        public virtual int ToDoListId { get; set; }
        
        public virtual string Body { get; set; }
        
        public virtual ToDoItem.ToDoItemStatus Status { get; set; }
        
        public virtual DateTime UpdatedAt { get; set; }
        
        public virtual DateTime CreatedAt { get; set; }
    }
}