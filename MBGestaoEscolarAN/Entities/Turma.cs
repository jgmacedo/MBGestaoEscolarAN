using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MBGestaoEscolarAN.Entities
{
    [Table("Turma")]
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurmaId { get; set; }

        [Required]
        [ForeignKey("Curso")]
        public int CursoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        [StringLength(150)]
        public string? Local { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidade { get; set; } = "Presencial";

        [Required]
        public int NumeroVagas { get; set; }

        [Required]
        [StringLength(30)]
        public string StatusTurma { get; set; } = "Planejada";
    }
}