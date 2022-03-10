using System;

namespace ToDo.Domain.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTarefa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
