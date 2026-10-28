using System.Diagnostics.Contracts;

namespace Acervo_Vinicius.Models
{
    public class Obras
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int AnoPublicacao { get; set; }
        public int TipoObraId { get; set; }
        public string ImagemUrl { get; set; }
        public int Status { get; set; }
        public int DataCadastro { get; set; }


    }
}
