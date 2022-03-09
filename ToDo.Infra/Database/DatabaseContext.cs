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


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Tarefa>().HasData(
        //        new Tarefa { Id = 1, Descricao = "ALVARO DIAS", DataTarefa = System.DateTime.Now, Titulo = "PODE" },
        //        new Tarefa { Id = 2, Descricao = "CABO DACIOLO", DataTarefa = System.DateTime.Now, Titulo = "PATRI" },
        //        new Tarefa { Id = 3, Descricao = "CIROS GOMES", DataTarefa = System.DateTime.Now, Titulo = "PDT" },
        //        new Tarefa { Id = 4, Descricao = "EYMAEL", DataTarefa = System.DateTime.Now, Titulo = "DC" },
        //        new Tarefa { Id = 5, Descricao = "FERNANDO HADDAD", DataTarefa = System.DateTime.Now, Titulo = "PT" },
        //        new Tarefa { Id = 6, Descricao = "GERALDO ALCKIMIN", DataTarefa = System.DateTime.Now, Titulo = "PSDB" },
        //        new Tarefa { Id = 7, Descricao = "GUILHERME BOULOS", DataTarefa = System.DateTime.Now, Titulo = "PSOL" },
        //        new Tarefa { Id = 8, Descricao = "HENRIQUE MEIRELLES", DataTarefa = System.DateTime.Now, Titulo = "MDB" },
        //        new Tarefa { Id = 9, Descricao = "JAIR BOLSONARO", DataTarefa = System.DateTime.Now, Titulo = "PSL" },
        //        new Tarefa { Id = 10, Descricao = "JOÃO AMOÊDO", DataTarefa = System.DateTime.Now, Titulo = "NOVO" },
        //        new Tarefa { Id = 11, Descricao = "JOÃO GOULART FILHO", DataTarefa = System.DateTime.Now, Titulo = "PPL" },
        //        new Tarefa { Id = 12, Descricao = "MARINA SILVA", DataTarefa = System.DateTime.Now, Titulo = "REDE" },
        //        new Tarefa { Id = 13, Descricao = "VERA", DataTarefa = System.DateTime.Now, Titulo = "PSTU" });
        //}
    }
}
