using toDoList.Models;
using toDoList.Models.Dto;

namespace toDoList.Services.Interfaces
{
    public interface IToDoItemServices
    {
        void AddToDoItem(NewTaskDTO newTaskDTO);
    }
}
