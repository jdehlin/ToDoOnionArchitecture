using System;
using System.Collections.Generic;
using System.ComponentModel;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Mvc.ViewModels
{
    public class ViewToDoList
    {
        public virtual int Id { get; set; }

        public virtual int UserId { get; set; }

        public virtual string Title { get; set; }

        [DisplayName("Created")]
        public virtual DateTime CreatedAt { get; set; }

        public List<ViewToDoItem> ToDoItems { get; set; }
    }
}