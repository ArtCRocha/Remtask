using Remtask.Context;
using Remtask.Models;
using Microsoft.EntityFrameworkCore;
using Remtask.Repositories.Interfaces;

namespace Remtask.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarefa> Tarefas => _context.Tarefas;

        public Tarefa GetTarefaById(int tarefaId)
        {
            return _context.Tarefas.FirstOrDefault(l => l.TarefaId == tarefaId);
        }


    }
}
