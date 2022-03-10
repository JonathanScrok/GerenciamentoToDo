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
            return await _db.Tarefas.ToListAsync(); //Lista todas as Tarefas do banco SqLite
        }
        #endregion

        #region Cria uma tarefa
        public async Task<bool> CreateTaskAsync(Tarefa tarefa)
        {
            try
            {
                Random randNum = new Random();

                tarefa.Codigo = randNum.Next(); //Gera o Código público da tarefa aleatóriamente
                tarefa.DataCriacao = DateTime.Now;

                await _db.Tarefas.AddAsync(tarefa); //Adiciona a nova tarefa ao banco SqLite
                await _db.SaveChangesAsync(); //Salva as alteraçoes 

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
                var todasTarefas = _db.Tarefas.ToList(); //Lista todas as Tarefas do banco SqLite
                Tarefa tarefa = todasTarefas.Where(a => a.Codigo == codigo).FirstOrDefault(); //Busca pelo codigo publico no banco

                if (tarefa != null)
                {
                    _db.Tarefas.Remove(tarefa); //Remove a tarefa do banco
                    await _db.SaveChangesAsync(); //Salva as alteraçoes 

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
                var todasTarefas = _db.Tarefas.ToList(); ////Lista todas as Tarefas do banco SqLite
                Tarefa tarefaCompleta = todasTarefas.Where(a => a.Codigo == codigo).FirstOrDefault(); //Busca pelo codigo publico no banco

                if (tarefa != null)
                {
                    tarefaCompleta.Descricao = tarefa.Descricao;
                    tarefaCompleta.Titulo = tarefa.Titulo;
                    tarefaCompleta.DataTarefa = tarefa.DataTarefa;

                    _db.Tarefas.Update(tarefaCompleta); //Atualiza as alteraçoes da tarefa 
                    await _db.SaveChangesAsync(); //Salva as alteraçoes 

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
