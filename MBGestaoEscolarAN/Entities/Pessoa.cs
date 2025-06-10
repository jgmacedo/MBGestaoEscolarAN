using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolarAN.Entities
{
    public class Pessoa
    {
        [Column(TypeName = "string")]
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        
    }
}
