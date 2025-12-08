using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class DaoClientes : DAO<Clientes>
    {
        public override string Salvar(object obj)
        {
            Clientes cliente = (Clientes)obj;
            string sql = "";
            if(cliente.IdCliente == 0)
                sql = "insert into clientes(nome, cpf, telefone, diarias, qtdPessoas, dataInicioReserva, dataFimReserva, valorPago, formaPagamento, idImovel) values (@nome, @cpf, @telefone, @diarias, @qtdPessoas, @dataInicioReserva, @dataFimReserva, @valorPago, @formaPagamento, @idImovel)";
            else
                sql = "update clientes set nome=@nome, cpf=@cpf, telefone=@telefone, diarias=@diarias, qtdPessoas=@qtdPessoas, dataInicioReserva=@dataInicioReserva, dataFimReserva=@dataFimReserva, valorPago=@valorPago, formaPagamento=@formaPagamento, idImovel=@idImovel where idCliente=@idCliente";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@diarias", cliente.Diarias);
                    cmd.Parameters.AddWithValue("@qtdPessoas", cliente.QtdPessoas);
                    cmd.Parameters.AddWithValue("@dataInicioReserva", cliente.DataInicioReserva);
                    cmd.Parameters.AddWithValue("@dataFimReserva", cliente.DataFimReserva);
                    cmd.Parameters.AddWithValue("@valorPago", cliente.ValorPago);
                    cmd.Parameters.AddWithValue("@formaPagamento", cliente.FormaPagamento);
                    cmd.Parameters.AddWithValue("@idImovel", cliente.OImovel.IdImovel);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select @@identity";
                    return "Cliente salvo com sucesso! ID: " + cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception e)
            {
                return "Erro ao salvar: " + e.Message;
            }
        }
        public override string Excluir(object obj)
        {
            Clientes cliente = (Clientes)obj;
            string sql = "delete from clientes where idCliente = @idCliente";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                    cmd.ExecuteNonQuery();
                    return "Cliente excluído com sucesso!";
                }
            }
            catch (Exception e)
            {
                return "Erro ao excluir: " + e.Message;
            }
        }
        public override List<Clientes> Listar()
        {
            string sql = "select * from clientes as c inner join imoveis as i on i.idImovel = c.idImovel order by c.idCliente";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Clientes> list = new List<Clientes>();
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
                        Clientes oCliente = new Clientes(
                            Convert.ToInt32(reader["idCliente"]),
                            Convert.ToString(reader["nome"]),
                            Convert.ToString(reader["cpf"]),
                            Convert.ToInt32(reader["diarias"]),
                            Convert.ToInt32(reader["qtdPessoas"]),
                            Convert.ToString(reader["telefone"]),
                            Convert.ToDateTime(reader["dataInicioReserva"]),
                            Convert.ToDateTime(reader["dataFimReserva"]),
                            Convert.ToDouble(reader["valorPago"]),
                            Convert.ToString(reader["formaPagamento"]),
                            oImovel
                        );
                        list.Add(oCliente);
                    }
                    reader.Close();
                    return list;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public override Object CarregaObj(int chave)
        {
            string sql = "select * from clientes as c inner join imoveis as i on i.idImovel = c.idImovel where c.idCliente = @chave";
            Imoveis oImovel = null;
            Clientes oCliente = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", chave);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
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
                        oCliente = new Clientes(
                            Convert.ToInt32(reader["idCliente"]),
                            Convert.ToString(reader["nome"]),
                            Convert.ToString(reader["cpf"]),
                            Convert.ToInt32(reader["diarias"]),
                            Convert.ToInt32(reader["qtdPessoas"]),
                            Convert.ToString(reader["telefone"]),
                            Convert.ToDateTime(reader["dataInicioReserva"]),
                            Convert.ToDateTime(reader["dataFimReserva"]),
                            Convert.ToDouble(reader["valorPago"]),
                            Convert.ToString(reader["formaPagamento"]),
                            oImovel
                        );
                    }
                    reader.Close();
                }
                return oCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public override List<Clientes> Pesquisar(string chave)
        {
            string sql = "select * from clientes as c inner join imoveis as i on i.idImovel = c.idImovel where c.nome like @chave or c.cpf like @chave or c.IdCliente like @chave or c.idImovel like @chave or @dataInicioReserva like @chave or @dataFimReserva like @chave or telefone like @chave order by c.idCliente";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + chave + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Clientes> list = new List<Clientes>();
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
                        Clientes oCliente = new Clientes(
                            Convert.ToInt32(reader["idCliente"]),
                            Convert.ToString(reader["nome"]),
                            Convert.ToString(reader["cpf"]),
                            Convert.ToInt32(reader["diarias"]),
                            Convert.ToInt32(reader["qtdPessoas"]),
                            Convert.ToString(reader["telefone"]),
                            Convert.ToDateTime(reader["dataInicioReserva"]),
                            Convert.ToDateTime(reader["dataFimReserva"]),
                            Convert.ToDouble(reader["valorPago"]),
                            Convert.ToString(reader["formaPagamento"]),
                            oImovel
                        );
                        list.Add(oCliente);
                    }
                    reader.Close();
                    return list;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
