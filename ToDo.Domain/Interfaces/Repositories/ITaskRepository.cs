﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repositories
{
    public interface ITaskRepository
    {
        Task<List<Tarefa>> ListTasksAsync();
        Task<bool> CreateTaskAsync(Tarefa tarefa);
        Task<bool> UpdateTaskAsync(Tarefa tarefa);
        Task<bool> DeleteTaskAsync(Tarefa tarefa);

    }
}
