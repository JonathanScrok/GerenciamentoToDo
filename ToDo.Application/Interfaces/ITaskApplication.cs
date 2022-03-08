using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;

namespace ToDo.Application.Interfaces
{
    public interface ITaskApplication
    {
        Task<List<TarefaRequest>> ListTasksAsync();
        Task<bool> CreateTaskAsync(TarefaRequest tarefa);
        Task<bool> DeleteTaskAsync(TarefaRequest tarefa);
        Task<bool> UpdateTaskAsync(TarefaRequest tarefa);
    }
}
