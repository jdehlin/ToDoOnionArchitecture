using System;

namespace ToDoApp.Domain.DataTransfer
{
    [Flags]
    public enum UserDependencies
    {
        None = -1,
        ToDoLists = 1
    }

    [Flags]
    public enum ToDoListDependencies
    {
        None = -1,
        ToDoItems = 1
    }
}