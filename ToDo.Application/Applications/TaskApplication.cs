using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;
using ToDo.Application.Interfaces;
using ToDo.Domain.Interfaces.Services;
using ToDo.Domain.Models;

namespace ToDo.Application.Applications
{
    public class TaskApplication : ITaskApplication
    {
        #region Atributos
        private readonly ITaskService _taskService;
        private readonly IMapper _mappper;
        #endregion

        #region Contrutor
        public TaskApplication(ITaskService taskService, IMapper mappper)
        {
            _taskService = taskService;
            _mappper = mappper;
        }
        #endregion

        #region Metodos

        public async Task<List<TarefaRequest>> ListTasksAsync()
        {
            var ListTarefaRequest = new List<TarefaRequest>();
            var result = await _taskService.ListTasksAsync();

            foreach (var tarefa in result)
            {
                var TarefaRequest = _mappper.Map<TarefaRequest>(tarefa);
                ListTarefaRequest.Add(TarefaRequest);
            }

            return ListTarefaRequest;
        }

        public async Task<bool> CreateTaskAsync(TarefaRequest tarefa)
        {
            var tarefaModel = _mappper.Map<Tarefa>(tarefa);
            return await _taskService.CreateTaskAsync(tarefaModel);
        }

        public async Task<bool> DeleteTaskAsync(TarefaRequest tarefa)
        {
            var tarefaModel = _mappper.Map<Tarefa>(tarefa);
            return await _taskService.DeleteTaskAsync(tarefaModel);
        }

        public async Task<bool> UpdateTaskAsync(TarefaRequest tarefa)
        {
            var tarefaModel = _mappper.Map<Tarefa>(tarefa);
            return await _taskService.UpdateTaskAsync(tarefaModel);
        }

        #endregion
    }
}
