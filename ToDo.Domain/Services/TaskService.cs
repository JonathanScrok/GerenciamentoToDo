using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Domain.Interfaces.Repositories;
using ToDo.Domain.Interfaces.Services;
using ToDo.Domain.Models;

namespace ToDo.Domain.Services
{
    public class TaskService : ITaskService
    {
        #region Atributos
        private readonly ITaskRepository _taskRepository;
        #endregion

        #region Contrutor
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        #endregion

        #region Metodos

        #region Lista todas Tarefas
        public Task<List<Tarefa>> ListTasksAsync()
        {
            return _taskRepository.ListTasksAsync();
        }
        #endregion

        #region Cria uma tarefa
        public Task<bool> CreateTaskAsync(Tarefa tarefa)
        {
            if (tarefa != null)
                return _taskRepository.CreateTaskAsync(tarefa);
            else
                return Task.FromResult(false);
        }
        #endregion

        #region Deleta uma tarefa
        public Task<bool> DeleteTaskAsync(int codigo)
        {
            if (codigo > 0)
                return _taskRepository.DeleteTaskAsync(codigo);
            else
                return Task.FromResult(false);
        }
        #endregion

        #region Atualiza uma tarefa
        public Task<bool> UpdateTaskAsync(int codigo, Tarefa tarefa)
        {
            if (tarefa != null)
                return _taskRepository.UpdateTaskAsync(codigo, tarefa);
            else
                return Task.FromResult(false);
        }
        #endregion

        #endregion
    }
}
