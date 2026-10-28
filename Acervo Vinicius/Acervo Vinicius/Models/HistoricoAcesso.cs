namespace Acervo_Vinicius.Models
{
    public class HistoricoAcesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ObraId { get; set; }
        public int DataAcesso { get; set; }
        public string TipoAcesso { get; set; } 

    }
}
