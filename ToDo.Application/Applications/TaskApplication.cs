using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;
using ToDo.Application.DataContract.Response.Tarefa;
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

        public async Task<List<TarefaResponse>> ListTasksAsync()
        {
            var ListTarefaRequest = new List<TarefaResponse>();
            var result = await _taskService.ListTasksAsync();

            foreach (var tarefa in result)
            {
                var TarefaRequest = _mappper.Map<TarefaResponse>(tarefa);
                ListTarefaRequest.Add(TarefaRequest);
            }

            return ListTarefaRequest;
        }

        public async Task<bool> CreateTaskAsync(TarefaRequest tarefa)
        {
            var tarefaModel = _mappper.Map<Tarefa>(tarefa);
            return await _taskService.CreateTaskAsync(tarefaModel);
        }

        public async Task<bool> DeleteTaskAsync(int codigo)
        {
            return await _taskService.DeleteTaskAsync(codigo);
        }

        public async Task<bool> UpdateTaskAsync(int codigo, TarefaRequest tarefa)
        {
            var tarefaModel = _mappper.Map<Tarefa>(tarefa);
            return await _taskService.UpdateTaskAsync(codigo, tarefaModel);
        }

        #endregion
    }
}
