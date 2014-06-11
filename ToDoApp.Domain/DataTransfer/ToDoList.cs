using System.Collections.Generic;

namespace ToDoApp.Domain.DataTransfer
{
    public partial class ToDoList
    {
        public IEnumerable<ToDoItem> ToDoItems { get; set; }  
    }
}