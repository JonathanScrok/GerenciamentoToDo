using System;

namespace ToDo.Application.DataContract.Response.Tarefa
{
    public sealed class TarefaResponse
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTarefa { get; set; }
    }
}
