using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class DaoImoveis : DAO<Imoveis>
    {
        public override string Salvar(object obj)
        {
            Imoveis oImovel = (Imoveis)obj;
            string sql = "";
            if (oImovel.IdImovel == 0)
            {
                sql = "insert into imoveis(rua, numero, bairro, cidade, disponibilidade, valorDiaria, despesas, tipoImovel) " +
                      "values (@rua, @numero, @bairro, @cidade, @disponibilidade, @valorDiaria, @despesas, @tipoImovel)";
            }
            else
            {
                sql = "update imoveis set rua=@rua, numero=@numero, bairro=@bairro, cidade=@cidade, " +
                      "disponibilidade=@disponibilidade, valorDiaria=@valorDiaria, despesas=@despesas, tipoImovel=@tipoImovel " +
                      "where idImovel=@idImovel";
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@idImovel", oImovel.IdImovel);
                    cmd.Parameters.AddWithValue("@rua", oImovel.Rua);
                    cmd.Parameters.AddWithValue("@numero", oImovel.Numero);
                    cmd.Parameters.AddWithValue("@bairro", oImovel.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", oImovel.Cidade);
                    cmd.Parameters.AddWithValue("@disponibilidade", oImovel.Disponibilidade);
                    cmd.Parameters.AddWithValue("@valorDiaria", oImovel.ValorDiaria);
                    cmd.Parameters.AddWithValue("@despesas", oImovel.Despesas);
                    cmd.Parameters.AddWithValue("@tipoImovel", oImovel.TipoImovel);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select @@identity";
                    return "Imóvel salvo com sucesso! ID: " + cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception e)
            {
                return "Erro ao salvar: " + e.Message;
            }
        }
        public override string Excluir(object obj)
        {
            Imoveis oImovel = (Imoveis)obj;
            string sql = "delete from imoveis where idImovel = @idImovel";
            try
            {
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@idImovel", oImovel.IdImovel);
                    cmd.ExecuteNonQuery();
                }
                return "Imovel de ID: " + oImovel.IdImovel + " Excluido com sucesso!";
            }
            catch (Exception e)
            {
                return "Não foi possivel excluir. Erro: " + e.Message;
            }
        }
        public override List<Imoveis> Pesquisar(string chave)
        {
            string sql = "select * from imoveis where rua like @chave or bairro like @chave or cidade like @chave or idImovel like @chave or disponibilidade like @chave or tipoImovel like @chave order by idImovel";
            try
            {
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Imoveis> list = new List<Imoveis>();
                    while (reader.Read())
                    {
                        Imoveis oImovel = new Imoveis(
                            Convert.ToInt32(reader["idImovel"]),
                            Convert.ToString(reader["rua"]),
                            Convert.ToInt32(reader["numero"]),
                            Convert.ToString(reader["bairro"]),
                            Convert.ToString(reader["cidade"]),
                            Convert.ToString(reader["disponibilidade"]),
                            Convert.ToDouble(reader["valorDiaria"]),
                            Convert.ToDouble(reader["despesas"]),
                            Convert.ToString(reader["tipoImovel"])
                        );
                        list.Add(oImovel);
                    }
                    reader.Close();
                    return list;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public override List<Imoveis> Listar()
        {
            string sql = "select * from imoveis order by idImovel";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Imoveis> list = new List<Imoveis>();
                    while (reader.Read())
                    {
                        Imoveis oImovel = new Imoveis(
                            Convert.ToInt32(reader["idImovel"]),
                            Convert.ToString(reader["rua"]),
                            Convert.ToInt32(reader["numero"]),
                            Convert.ToString(reader["bairro"]),
                            Convert.ToString(reader["cidade"]),
                            Convert.ToString(reader["disponibilidade"]),
                            Convert.ToDouble(reader["valorDiaria"]),
                            Convert.ToDouble(reader["despesas"]),
                            Convert.ToString(reader["tipoImovel"])
                        );
                        list.Add(oImovel);
                    }
                    reader.Close();
                    return list;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public override object CarregaObj(int chave)
        {
            string sql = "select * from imoveis where idImovel = @chave";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", chave);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Imoveis oImovel = null;
                    if(reader.Read())
                    {
                        oImovel = new Imoveis(
                            Convert.ToInt32(reader["idImovel"]),
                            Convert.ToString(reader["rua"]),
                            Convert.ToInt32(reader["numero"]),
                            Convert.ToString(reader["bairro"]),
                            Convert.ToString(reader["cidade"]),
                            Convert.ToString(reader["disponibilidade"]),
                            Convert.ToDouble(reader["valorDiaria"]),
                            Convert.ToDouble(reader["despesas"]),
                            Convert.ToString(reader["tipoImovel"])
                        );
                    }
                    reader.Close();
                    return oImovel;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
