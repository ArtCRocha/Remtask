using Remtask.Models;

namespace Remtask.Repositories.Interfaces
{
    public interface ITarefaRepository
    {
        IEnumerable<Tarefa> Tarefas { get; }

        Tarefa GetTarefaById(int tarefaId);
    }
}
