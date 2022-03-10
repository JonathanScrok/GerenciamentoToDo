using System;

namespace ToDo.Application.DataContract.Request.Tarefa
{
    public sealed class TarefaRequest
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTarefa { get; set; }
    }
}
