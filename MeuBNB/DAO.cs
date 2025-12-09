using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class DAO<T>
    {
        protected SqlConnection cnn;
        public DAO()
        {
            cnn = Banco.Abrir();
        }
        public virtual string Salvar(object obj)
        {
            return "Não implementado";
        }
        public virtual string Excluir(object obj)
        {
            return "Não implementado";
        }
        public virtual List<T> Listar()
        {
            return null;
        }
        public virtual List<T> Pesquisar(string chave, string filtro)
        { 
            return null; 
        }
        public virtual Object CarregaObj(int chave)
        {   
            return null; 
        }
    }
}
