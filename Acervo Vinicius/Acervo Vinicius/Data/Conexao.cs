using Microsoft.Data.Sqlite;

namespace Acervo_Vinicius.Data
{
    public class Conexao
    {
        private static readonly string CaminhoBanco = Path.Combine(Directory.GetCurrentDirectory(), "Data", "acervo_digital.db");
        private static readonly string ConnectionString = $"Data Source={CaminhoBanco};";
        public static SqliteConnection ObterConexao()
        {
            var conexao = new SqliteConnection(ConnectionString);
            conexao.Open();
            return conexao;
        }

    }
}
