using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Remtask.Models
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "Obrigatório colocar o titulo")]
        public string TituloTarefa { get; set; }

        [Required(ErrorMessage = "Obrigatório colocar o Dia")]
        public string DiaTarefa { get; set; }

        [Required(ErrorMessage = "Obrigatório colocar o horário")]
        public string Horario { get; set; }

    }
}
