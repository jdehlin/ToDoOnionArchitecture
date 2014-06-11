using System;
using System.ComponentModel;

namespace ToDoApp.Website.Mvc.ViewModels
{
    public class ViewToDoList
    {
        public virtual int Id { get; set; }

        public virtual int UserId { get; set; }

        public virtual string Title { get; set; }

        [DisplayName("Created")]
        public virtual DateTime CreatedAt { get; set; } 
    }
}