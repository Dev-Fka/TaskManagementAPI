using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementAPI.Application.İnterfaces;
using TaskManagementAPI.Domain.Entities;

namespace TaskManagementAPI.Application.Features.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ITaskRepository taskRepository;

        public CreateTaskCommandHandler(ITaskRepository _taskRepository)
        {
            this.taskRepository = _taskRepository;
        }
        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskEntity = new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                CreatedAt = DateTime.UtcNow,
                Status = Domain.Enums.TaskStatus.Todo
            };

            var task = await taskRepository.AddTaskAsync(taskEntity);

            return task.Id;
        }
    }
}
