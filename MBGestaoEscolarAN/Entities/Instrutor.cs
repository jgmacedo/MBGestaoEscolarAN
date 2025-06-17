using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Instrutor")]
    public class Instrutor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstrutorId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }

        [StringLength(200)]
        public string FormacaoAcademica { get; set; }

        [StringLength(150)]
        public string Especialidade { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorHoraAula { get; set; }

        [Required]
        [StringLength(20)]
        public string StatusInstrutor { get; set; }
    }
}