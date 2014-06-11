using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ToDoApp.Domain.Models;

namespace ToDoApp.Website.Mvc.ViewModels
{
    public class ViewUser
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        [DisplayName("Created")]
        public virtual DateTime CreatedAt { get; set; }

        public List<ViewToDoList> ToDoLists { get; set; }
    }
}