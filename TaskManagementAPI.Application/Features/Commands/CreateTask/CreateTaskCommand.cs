using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementAPI.Application.Features.Commands.CreateTask
{
    public class CreateTaskCommand:IRequest<Guid>
    {
        public string Title{ get; set; }
        public string Description{ get; set; }
        public DateTime DueDate{ get; set; }
    }
}
