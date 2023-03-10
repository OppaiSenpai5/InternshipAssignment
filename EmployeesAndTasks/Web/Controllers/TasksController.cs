using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs;
using ServiceLayer.Services.TaskService;

namespace Web.Controllers
{
    [Route("api/v1/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TasksController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute] int id)
        {
            var task = this.taskService.Get(id);
            return task is null ? NotFound() : Ok(task);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.taskService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromForm] TaskDto task)
        {
            this.taskService.Create(task);
            return CreatedAtAction(nameof(Get), task);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromForm] TaskDto task)
        {
            this.taskService.Update(id, task);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            this.taskService.Delete(id);
            return NoContent();
        }
    }
}
