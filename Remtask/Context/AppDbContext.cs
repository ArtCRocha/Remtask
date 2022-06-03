using Microsoft.EntityFrameworkCore;
using Remtask.Models;

namespace Remtask.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
