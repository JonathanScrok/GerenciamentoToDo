using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.DataContract.Request.Tarefa;
using ToDo.Application.DataContract.Response.Tarefa;
using ToDo.Domain.Models;

namespace ToDo.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            TarefaMap();
        }
        private void TarefaMap()
        {
            CreateMap<TarefaRequest, Tarefa>();
            CreateMap<Tarefa, TarefaRequest>();
            CreateMap<Tarefa, TarefaResponse>();
        }
    }
}
