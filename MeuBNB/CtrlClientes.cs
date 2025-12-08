using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBNB
{
    internal class CtrlClientes : Controller<Clientes>
    {
        DaoClientes aDao;
        protected CtrlImoveis ctrlImoveis;
        public CtrlClientes()
        {
            aDao = new DaoClientes();
            ctrlImoveis = new CtrlImoveis();
        }
        public CtrlImoveis CtrlImoveis { get => ctrlImoveis; set => ctrlImoveis = value; }
        public override string Salvar(object obj)
        {
            return aDao.Salvar(obj);
        }
        public override string Excluir(object obj)
        {
            return aDao.Excluir(obj);
        }
        public override List<Clientes> Listar()
        {
            return aDao.Listar();
        }
        public override Object CarregaObj(int chave)
        {
            return aDao.CarregaObj(chave);
        }
        public override List<Clientes> Pesquisar(string chave)
        {
            return aDao.Pesquisar(chave);
        }
    }
}
