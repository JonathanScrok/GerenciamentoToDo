using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Services
{
    public interface ITaskService
    {
        Task<List<Tarefa>> ListTasksAsync();
        Task<bool> CreateTaskAsync(Tarefa tarefa);
        Task<bool> UpdateTaskAsync(int codigo, Tarefa tarefa);
        Task<bool> DeleteTaskAsync(int codigo);
    }
}
