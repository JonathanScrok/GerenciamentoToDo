using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.DataContract.Request.Tarefa
{
    public sealed class TarefaRequest
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTarefa { get; set; }
    }
}
