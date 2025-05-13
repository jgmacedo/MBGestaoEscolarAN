namespace MBGestaoEscolarAN.Entities
{
    public class Instrutor
    {
        public int InstrutorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string FormacaoAcademica { get; set; }
        public string Especialidade { get; set; }
        public decimal Salario { get; set; }
        public string StatusInstrutor { get; set; }
    }
}
