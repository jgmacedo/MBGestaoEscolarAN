using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CursoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; } = string.Empty;

        [Column(TypeName = "text")]
        public string? Descricao { get; set; }

        [Required]
        public int CargaHoraria { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidade { get; set; } = "Presencial";

        [StringLength(100)]
        public string? Trilha { get; set; }

        public int PontosCAP { get; set; } = 0;

        [Required]
        [StringLength(20)]
        public string StatusCurso { get; set; } = "Ativo";

        [ForeignKey("Coordenador")]
        public int? CoordenadorId { get; set; }

        // Propriedades de navegação
        public virtual ICollection<Turma> Turmas { get; set; } = new List<Turma>();
    }
}