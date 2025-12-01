using System.ComponentModel.DataAnnotations;

namespace DisciplinasApi.Models
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int CargaHoraria { get; set; }

        public string? Professor { get; set; }
    }
}
