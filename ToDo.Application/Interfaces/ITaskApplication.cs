using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;
using ToDo.Application.DataContract.Response.Tarefa;

namespace ToDo.Application.Interfaces
{
    public interface ITaskApplication
    {
        Task<List<TarefaResponse>> ListTasksAsync();
        Task<bool> CreateTaskAsync(TarefaRequest tarefa);
        Task<bool> DeleteTaskAsync(int codigo);
        Task<bool> UpdateTaskAsync(int codigo, TarefaRequest tarefa);
    }
}
