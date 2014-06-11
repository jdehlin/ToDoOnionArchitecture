using System.Collections.Generic;

namespace ToDoApp.Domain.DataTransfer
{
    public partial class User
    {
        public IEnumerable<ToDoList> ToDoLists { get; set; }
    }
}