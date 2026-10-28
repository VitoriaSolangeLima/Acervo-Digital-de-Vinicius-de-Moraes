namespace Acervo_Vinicius.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public string Album { get; set; }
        public int DuracaoSegundos { get; set; }
        public int GravacaoOriginal { get; set; }


    }
}
