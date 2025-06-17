using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    [Table("Turma")] // <--- Add this line
    public class Turma
    {
        public int TurmaId {  get; set; }
        public int CursoId { get; set; }
        public string Nome {  get; set; }
        public string Codigo {  get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Local {  get; set; }
        public string Modalidade {  get; set; }
        public Int32 NumeroVagas {  get; set; }
        public string StatusTurma {  get; set; }
    }
}
