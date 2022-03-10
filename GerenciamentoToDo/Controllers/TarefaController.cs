using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;
using ToDo.Application.Interfaces;

namespace ToDo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        #region Atributos
        private readonly ITaskApplication _taskApplication;
        #endregion

        #region Contrutor
        public TarefaController(ITaskApplication taskApplication)
        {
            _taskApplication = taskApplication;
        }
        #endregion

        #region Metodos

        #region Listar todas tarefas
        // GET: TarefaController/ListarTarefas
        /// <summary>
        /// Lista todas as tarefas
        /// </summary>
        [HttpGet("listar-tarefas")]
        public async Task<ActionResult> ListarTarefas()
        {
            var result = await _taskApplication.ListTasksAsync();

            if (result.Count > 0)
                return Ok(result);
            else
                return NotFound("Nenhuma tarefa encontrada!");
        }
        #endregion

        #region Adicionar tarefa
        // POST: TarefaController/AdicionarTarefa
        /// <summary>
        /// Adiciona uma nova tarefa
        /// </summary>
        [HttpPost("adicionar-tarefa")]
        public async Task<ActionResult> AdicionarTarefa([FromBody] TarefaRequest tarefa)
        {
            var result = await _taskApplication.CreateTaskAsync(tarefa);

            if (result)
                return Ok("Tarefa criada com sucesso!");
            else
                return BadRequest("Erro ao criar a tarefa!");

        }
        #endregion

        #region Alterar Tarefa
        // PUT: TarefaController/AlterarTarefa
        /// <summary>
        /// Altera uma tarefa existente
        /// </summary>
        [HttpPut("alterar-tarefa/{codigo}")]
        public async Task<ActionResult> AlterarTarefa(int codigo, [FromBody] TarefaRequest tarefa)
        {
            var result = await _taskApplication.UpdateTaskAsync(codigo, tarefa);

            if (result)
                return Ok("Tarefa alterada com sucesso!");
            else
                return BadRequest("Erro ao alterar a tarefa!");
        }
        #endregion

        #region Deletar Tarefa
        // DELETE: TarefaController/DeletarTarefa
        /// <summary>
        /// Deleta uma tarefa existente
        /// </summary>
        [HttpDelete("deletar-tarefa/{codigo}")]
        public async Task<ActionResult> DeletarTarefa(int codigo)
        {
            var result = await _taskApplication.DeleteTaskAsync(codigo);

            if (result)
                return Ok("Tarefa deletada com sucesso!");
            else
                return BadRequest("Erro ao deletar a tarefa!");
        }
        #endregion

        #endregion
    }
}
