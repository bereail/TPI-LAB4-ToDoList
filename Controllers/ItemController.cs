using Microsoft.AspNetCore.Mvc;
using toDoList.Models.Dto;
using toDoList.Services.Interfaces;

namespace toDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IToDoItemServices _toDoItemServices;


        public ItemController(IToDoItemServices toDoItemServices)
        {
            _toDoItemServices = toDoItemServices;
        }

        [HttpPost("newItem")]
        public IActionResult AddToDoItem(NewTaskDTO newTaskDTO)
        {
            try
            {
                _toDoItemServices.AddToDoItem(newTaskDTO);
                return Ok("Nueva tarea agregada correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar la tarea: {ex.Message}");
            }
        }
    }
}
