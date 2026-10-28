namespace Acervo_Vinicius.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public string TipoUsuario { get; set; }
        public int Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
