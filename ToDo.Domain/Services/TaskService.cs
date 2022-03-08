using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Interfaces.Repositories;
using ToDo.Domain.Interfaces.Services;
using ToDo.Domain.Models;

namespace ToDo.Domain.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        #region Contrutor
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        #endregion

        #region Metodos
        public Task<List<Tarefa>> ListTasksAsync()
        {
            return _taskRepository.ListTasksAsync();
        }

        public Task<bool> CreateTaskAsync(Tarefa tarefa)
        {
            if (tarefa != null)
                return _taskRepository.CreateTaskAsync(tarefa);
            else
                return Task.FromResult(false);
        }

        public Task<bool> DeleteTaskAsync(Tarefa tarefa)
        {
            if (tarefa != null)
                return _taskRepository.DeleteTaskAsync(tarefa);
            else
                return Task.FromResult(false);
        }

        public Task<bool> UpdateTaskAsync(Tarefa tarefa)
        {
            if (tarefa != null)
                return _taskRepository.UpdateTaskAsync(tarefa);
            else
                return Task.FromResult(false);
        }
        #endregion
    }
}
