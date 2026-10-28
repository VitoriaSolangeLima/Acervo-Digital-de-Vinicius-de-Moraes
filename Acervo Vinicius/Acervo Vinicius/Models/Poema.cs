namespace Acervo_Vinicius.Models
{
    public class Poema
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public string TextoAutorizado { get; set; }
        public string Tema { get; set; }
    }
}
