namespace Acervo_Vinicius.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public string ISBN { get; set; }
        public string Editora { get; set; }
        public int NumeroPaginas { get; set; }
        public string Edicao { get; set; }
        public string Formato { get; set; }

    }
}
