using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementAPI.Domain.Entities
{
    public class User :BaseEntity
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public ICollection<TaskItem>? AssignedItems { get; set; }
    }
}
