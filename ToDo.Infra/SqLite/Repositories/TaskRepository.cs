using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Interfaces.Repositories;
using ToDo.Domain.Models;
using ToDo.Infra.Database;

namespace ToDo.Infra.SqLite.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        #region Atributos
        private readonly DatabaseContext _db;
        #endregion

        #region Contrutor
        public TaskRepository(DatabaseContext db)
        {
            _db = db;
        }
        #endregion

        #region Metodos

        #region Lista todas Tarefas
        public async Task<List<Tarefa>> ListTasksAsync()
        {
            return await _db.Tarefas.ToListAsync();
        }
        #endregion

        #region Cria uma tarefa
        public async Task<bool> CreateTaskAsync(Tarefa tarefa)
        {
            try
            {
                Random randNum = new Random();
                int codigo = randNum.Next();

                tarefa.Codigo = codigo;
                tarefa.DataCriacao = DateTime.Now;

                await _db.Tarefas.AddAsync(tarefa);
                await _db.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Deleta uma tarefa
        public async Task<bool> DeleteTaskAsync(int codigo)
        {
            try
            {
                var todasTarefas = _db.Tarefas.ToList();
                Tarefa tarefa = todasTarefas.Where(a => a.Codigo == codigo).FirstOrDefault();

                if (tarefa != null)
                {
                    _db.Tarefas.Remove(tarefa);
                    await _db.SaveChangesAsync();

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Atualiza uma tarefa
        public async Task<bool> UpdateTaskAsync(int codigo, Tarefa tarefa)
        {
            try
            {
                var todasTarefas = _db.Tarefas.ToList();
                Tarefa tarefaCompleta = todasTarefas.Where(a => a.Codigo == codigo).FirstOrDefault();

                if (tarefa != null)
                {
                    tarefaCompleta.Descricao = tarefa.Descricao;
                    tarefaCompleta.Titulo = tarefa.Titulo;
                    tarefaCompleta.DataTarefa = tarefa.DataTarefa;

                    _db.Tarefas.Update(tarefaCompleta);
                    await _db.SaveChangesAsync();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #endregion
    }
}
