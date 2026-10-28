namespace Acervo_Vinicius.Models
{
    public class Favorito
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ObraId { get; set; }
        public int DataInclusao { get; set; }
    }
}
