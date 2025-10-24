using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementAPI.Application.İnterfaces;
using TaskManagementAPI.Domain.Entities;
using TaskManagementAPI.Infrastructure.Data;

namespace TaskManagementAPI.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        public TaskRepository(ApplicationDbContext dbContext) { 
            this._context = dbContext;
        }

        public async Task<TaskItem> AddTaskAsync(TaskItem item)
        {   
            await _context.Tasks.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<int> DeleteTaskAsync(Guid id)
        {   
            
            return await _context.Tasks.Where(t => t.Id == id).ExecuteDeleteAsync();
           
        }

        public async Task<List<TaskItem>> GetAllTaskAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskItem> GetTaskByIDAsync(Guid id)
        {
            return await _context.Tasks.FirstAsync(t => t.Id == id);
        }

        public async Task<int> UpdateTaskAsync(TaskItem item)
        {
            return await _context.Tasks.Where(t => t.Id == item.Id).ExecuteUpdateAsync(setter => setter.SetProperty(i => i.Status,item.Status)
            .SetProperty(i => i.UpdatedAt , DateTime.Now)
            
        );
        }
    }
}
