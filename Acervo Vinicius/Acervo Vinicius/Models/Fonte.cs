namespace Acervo_Vinicius.Models
{
    public class Fonte
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public string TipoFonte { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
        public string Plataforma { get; set; }
        public int Autorizada { get; set; }
        public int Ativa { get; set; }

    }
}
