using TaskManagementAPI.Domain.Entities;

namespace TaskManagementAPI.Application.İnterfaces
{
    public interface ITaskRepository
    {

        Task<TaskItem> AddTaskAsync(TaskItem item);
        Task<List<TaskItem>> GetAllTaskAsync();
        Task<TaskItem> GetTaskByIDAsync(Guid id);
        Task<int> UpdateTaskAsync(TaskItem item);
        Task<int> DeleteTaskAsync(Guid id);
    }
}
