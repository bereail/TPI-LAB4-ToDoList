using toDoList.Models;
using toDoList.Models.Dto;
using toDoList.Services.Interfaces;

namespace toDoList.Services.Implementations
{
    public class ToDoItemServices : IToDoItemServices
    {

        private readonly toDoListDbContext _toDoListDbContext;
     
        public ToDoItemServices(toDoListDbContext toDoListDbContext)
        {
           _toDoListDbContext = toDoListDbContext;
        }


        public void AddToDoItem(NewTaskDTO newTaskDTO)
        {
            if (newTaskDTO == null)
            {
                throw new ArgumentNullException(nameof(newTaskDTO), "El argumento no puede ser nulo");
            }
            else
            {
                var toDoItem = new ToDoItem
                {
                    UserId = newTaskDTO.IdUser,
                    Title = newTaskDTO.Title,
                    Description = newTaskDTO.Description
                };

                _toDoListDbContext.ToDoItem.Add(toDoItem);
                _toDoListDbContext.SaveChanges();
            }
        }
    }
    }

