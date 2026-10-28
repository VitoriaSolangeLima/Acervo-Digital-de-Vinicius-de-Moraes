namespace Acervo_Vinicius.Models
{
    public class Video
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public int DuracaoSegundos { get; set; }
        public string Canal { get; set; }
        public int YoutubeVideoId { get; set; }
    }
}
