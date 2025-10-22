using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Application.Services;

namespace TaskManagementAPI.Controllers
{
    [ApiController]
    public class TasksController : Controller
    {   
        public TaskService TaskService { get; set; } 

        public TasksController(TaskService service) {
            TaskService = service;
        }

    }
}
