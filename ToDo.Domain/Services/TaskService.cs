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

        public Task<List<Tarefa>> ListTasksAsync()
        {
            return _taskRepository.ListTasksAsync();
        }

        public Task<bool> CreateTaskAsync(Tarefa tarefa)
        {
            _taskRepository.CreateTaskAsync(tarefa);

            throw new NotImplementedException();
        }

        public Task<bool> DeleteTaskAsync(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateTaskAsync(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}
