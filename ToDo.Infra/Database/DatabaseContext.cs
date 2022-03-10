using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Models;

namespace ToDo.Infra.Database
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Tarefa> Tarefas { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //EF - Garantir que o banco seja criado pelo EF - Code First
            Database.EnsureCreated();
        }
    }
}
