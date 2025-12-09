using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class CtrlImoveis : Controller<Imoveis>
    {
        DaoImoveis aDAO;
        public CtrlImoveis()
        {
            aDAO = new DaoImoveis();
        }
        public override string Salvar(object obj)
        {
            return aDAO.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDAO.Excluir(obj);
        }
        public override List<Imoveis> Listar()
        {
            return aDAO.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDAO.CarregaObj(chave);
        }
        public override List<Imoveis> Pesquisar(string chave, string filtro)
        {
            return aDAO.Pesquisar(chave, filtro);
        }
    }
}
