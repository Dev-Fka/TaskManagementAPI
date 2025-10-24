using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementAPI.Domain.Enums;

namespace TaskManagementAPI.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Todo;
        public Guid AssignedUserId { get; set; }
    }
}
