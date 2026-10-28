namespace Acervo_Vinicius.Models
{
    public class Avaliacoes
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ObraId { get; set; }
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public int DataAvaliacao { get; set; }
        public int Aprovada { get; set; }


    }
}

