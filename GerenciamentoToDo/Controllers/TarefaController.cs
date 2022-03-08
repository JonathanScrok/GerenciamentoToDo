using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [HttpPost("adicionar-tarefa")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AdicionarTarefa([FromBody] TarefaRequest tarefa)
        {
            var result = await _taskApplication.CreateTaskAsync(tarefa);

            if (result)
                return Ok(true);
            else
                return BadRequest("Erro ao criar a tarefa!");

        }
        #endregion

        #region Alterar Tarefa
        // PUT: TarefaController/AlterarTarefa
        [HttpPut("alterar-tarefa")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AlterarTarefa([FromBody] TarefaRequest tarefa)
        {
            var result = await _taskApplication.UpdateTaskAsync(tarefa);

            if (result)
                return Ok(true);
            else
                return BadRequest("Erro ao alterar a tarefa!");
        }
        #endregion

        #region Deletar Tarefa
        // DELETE: TarefaController/DeletarTarefa
        [HttpDelete("deletar-tarefa")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeletarTarefa([FromBody] TarefaRequest tarefa)
        {
            var result = await _taskApplication.DeleteTaskAsync(tarefa);

            if (result)
                return Ok(true);
            else
                return BadRequest("Erro ao deletar a tarefa!");
        }
        #endregion

        #endregion
    }
}
