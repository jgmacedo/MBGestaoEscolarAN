using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolarAN.ViewModels
{
    public class TurmaViewModel
    {
        public int TurmaId { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório")]
        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        public string NomeCurso { get; set; } = "";

        [Required(ErrorMessage = "O nome da turma é obrigatório")]
        [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres")]
        [Display(Name = "Nome da Turma")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "O código é obrigatório")]
        [StringLength(50, ErrorMessage = "O código deve ter no máximo 50 caracteres")]
        [Display(Name = "Código")]
        public string Codigo { get; set; } = "";

        [Required(ErrorMessage = "A data de início é obrigatória")]
        [Display(Name = "Data de Início")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "A data de fim é obrigatória")]
        [Display(Name = "Data de Fim")]
        public DateTime DataFim { get; set; }

        [StringLength(150, ErrorMessage = "O local deve ter no máximo 150 caracteres")]
        [Display(Name = "Local")]
        public string Local { get; set; } = "";

        [Required(ErrorMessage = "A modalidade é obrigatória")]
        [StringLength(50, ErrorMessage = "A modalidade deve ter no máximo 50 caracteres")]
        [Display(Name = "Modalidade")]
        public string Modalidade { get; set; } = "";

        [Required(ErrorMessage = "O número de vagas é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O número de vagas deve ser maior ou igual a 0")]
        [Display(Name = "Número de Vagas")]
        public Int32 NumeroVagas { get; set; }

        [Required(ErrorMessage = "O status da turma é obrigatório")]
        [StringLength(30, ErrorMessage = "O status deve ter no máximo 30 caracteres")]
        [Display(Name = "Status da Turma")]
        public string StatusTurma { get; set; } = "";

        // Propriedades específicas da UI
        public bool IsEdicao => TurmaId > 0;
        public string TituloFormulario => IsEdicao ? "Editar Turma" : "Nova Turma";
        public string TextoBotao => IsEdicao ? "Atualizar" : "Salvar";


    }
}
