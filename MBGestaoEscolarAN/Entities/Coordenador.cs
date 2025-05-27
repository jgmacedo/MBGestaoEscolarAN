namespace MBGestaoEscolarAN.Entities
{
    public class Coordenador : Pessoa
    {
        public int CoordenadorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}

