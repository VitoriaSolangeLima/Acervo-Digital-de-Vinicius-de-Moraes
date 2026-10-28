using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Acervo_Vinicius.Models;
using Acervo_Vinicius.Data;
using System.Security.Cryptography.X509Certificates;

namespace Acervo_Vinicius.Pages
{
    public class IndexModel : PageModel
    {
        public List<Obras> ListaObras { get; set; } = new List<Obras>();

        public void OnGet()
        {
            var obraDB = new ObraDB();
            ListaObras = obraDB.ListarTodas();
        }

        public IActionResult OnPostInserirExemplo()
        {
            var obraDB = new ObraDB();
            obraDB.Inserir(new Obras
            {
                Titulo = "Soneto de Fidelidade",
                Descricao = "Poema que fala sobre a fidelidade em um relacionamento amoroso.",
                AnoPublicacao = 1939,
                TipoObraId = 1,
                Status = 1,
                DataCadastro = 20261028
            });
            return RedirectToPage();
        }
    }
}
