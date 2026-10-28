using Acervo_Vinicius.Models;
using Microsoft.Data.Sqlite;

namespace Acervo_Vinicius.Data
{
    public class ObraDB
    {
        // 1. LISTAR TODAS AS OBRAS (READ)
        public List<Obras> ListarTodas()
        {
            var lista = new List<Obras>();

            using (var conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT Id, Titulo, Descricao, AnoPublicacao, TipoObraId, ImagemUrl, Status, DataCadastro FROM Obras";

                using (var comando = new SqliteCommand(sql, conexao))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obra = new Obras
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Titulo = reader["Titulo"].ToString()!,
                            Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString()! : "",
                            AnoPublicacao = reader["AnoPublicacao"] != DBNull.Value ? Convert.ToInt32(reader["AnoPublicacao"]) : 0,
                            TipoObraId = Convert.ToInt32(reader["TipoObraId"]),
                            ImagemUrl = reader["ImagemUrl"] != DBNull.Value ? reader["ImagemUrl"].ToString()! : "",
                            Status = Convert.ToInt32(reader["Status"]),
                            DataCadastro = Convert.ToInt32(reader["DataCadastro"])
                        };

                        lista.Add(obra);
                    }
                }
            }

            return lista;
        }

        // 2. BUSCAR UMA OBRA PELO ID (READ)
        public Obras? BuscarPorId(int id)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string sql = "SELECT Id, Titulo, Descricao, AnoPublicacao, TipoObraId, ImagemUrl, Status, DataCadastro FROM Obras WHERE Id = @Id";

                using (var comando = new SqliteCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Obras
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Titulo = reader["Titulo"].ToString()!,
                                Descricao = reader["Descricao"] != DBNull.Value ? reader["Descricao"].ToString()! : "",
                                AnoPublicacao = reader["AnoPublicacao"] != DBNull.Value ? Convert.ToInt32(reader["AnoPublicacao"]) : 0,
                                TipoObraId = Convert.ToInt32(reader["TipoObraId"]),
                                ImagemUrl = reader["ImagemUrl"] != DBNull.Value ? reader["ImagemUrl"].ToString()! : "",
                                Status = Convert.ToInt32(reader["Status"]),
                                DataCadastro = Convert.ToInt32(reader["DataCadastro"])
                            };
                        }
                    }
                }
            }

            return null; // Caso não encontre
        }

        // 3. INSERIR UMA NOVA OBRA (CREATE)
        public void Inserir(Obras obra)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Obras (Titulo, Descricao, AnoPublicacao, TipoObraId, ImagemUrl, Status, DataCadastro)
                               VALUES (@Titulo, @Descricao, @AnoPublicacao, @TipoObraId, @ImagemUrl, @Status, @DataCadastro)";

                using (var comando = new SqliteCommand(sql, conexao))
                {
                    // Uso de parâmetros para evitar SQL Injection (regra de ouro em LP III)
                    comando.Parameters.AddWithValue("@Titulo", obra.Titulo);
                    comando.Parameters.AddWithValue("@Descricao", (object?)obra.Descricao ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@AnoPublicacao", obra.AnoPublicacao);
                    comando.Parameters.AddWithValue("@TipoObraId", obra.TipoObraId);
                    comando.Parameters.AddWithValue("@ImagemUrl", (object?)obra.ImagemUrl ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@Status", obra.Status);
                    comando.Parameters.AddWithValue("@DataCadastro", obra.DataCadastro);

                    comando.ExecuteNonQuery(); // Executa o comando sem esperar retorno de tabela
                }
            }
        }

        // 4. ATUALIZAR UMA OBRA (UPDATE)
        public void Atualizar(Obras obra)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string sql = @"UPDATE Obras 
                               SET Titulo = @Titulo, 
                                   Descricao = @Descricao, 
                                   AnoPublicacao = @AnoPublicacao, 
                                   TipoObraId = @TipoObraId, 
                                   ImagemUrl = @ImagemUrl, 
                                   Status = @Status 
                               WHERE Id = @Id";

                using (var comando = new SqliteCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", obra.Id);
                    comando.Parameters.AddWithValue("@Titulo", obra.Titulo);
                    comando.Parameters.AddWithValue("@Descricao", (object?)obra.Descricao ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@AnoPublicacao", obra.AnoPublicacao);
                    comando.Parameters.AddWithValue("@TipoObraId", obra.TipoObraId);
                    comando.Parameters.AddWithValue("@ImagemUrl", (object?)obra.ImagemUrl ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@Status", obra.Status);

                    comando.ExecuteNonQuery();
                }
            }
        }

        // 5. EXCLUIR UMA OBRA (DELETE)
        public void Excluir(int id)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                string sql = "DELETE FROM Obras WHERE Id = @Id";

                using (var comando = new SqliteCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}