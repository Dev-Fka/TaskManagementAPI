using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Application.Features.Commands.CreateTask;
using TaskManagementAPI.Application.Services;
using TaskManagementAPI.Domain.Entities;
using TaskManagementAPI.Infrastructure.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TaskManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : Controller
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /*
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTasks()
        {
            
        }*/

        // POST: api/tasks
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateTask([FromBody] CreateTaskCommand command)
        {
            var taskID = await _mediator.Send(command);

            return taskID;
        }
    }
}
